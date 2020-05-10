import React , {Component} from 'react'
import Button from '../../../components/UI/Button/Button'
import classes from './ContactData.module.css'
import axios from '../../../AxiosOrder'
import Spinner from '../../../components/UI/Spinner/Spinner'
import Input from '../../../components/UI/Input/Input'



//class component to set the contact data of the customer
class ContactData extends Component{

    //states that are needed for the customer to placce an order
    state={
        orderForm:{
                name:{
                    elementType:'input',
                    elementConfig:{
                        type:'text',
                        placeholder:'Enter your name'
                    },
                    value:'',
                    validation:{
                        required:true
                    },
                    valid:false,
                    touched:false
                },
                age:{
                    elementType:'input',
                    elementConfig:{
                        type:'text',
                        placeholder:'Enter your age'
                    },
                    value:'',
                    validation:{
                        required:true,
                        isNumeric: true
                    },
                    valid:false,
                    touched:false
                },
                state:{
                    elementType:'input',
                    elementConfig:{
                        type:'text',
                        placeholder:'Enter your city'
                    },
                    value:'',
                    validation:{
                        required:true
                    },
                    valid:false,
                    touched:false
                },
                country:{
                    elementType:'input',
                    elementConfig:{
                        type:'text',
                        placeholder:'Enter your country'
                    },
                    value:'',
                    validation:{
                        required:true
                    },
                    valid:false,
                    touched:false
                },
                PinCode:{
                    elementType:'input',
                    elementConfig:{
                        type:'text',
                        placeholder:'Enter your PIN Code'
                    },
                    value:'',
                    validation:{
                        required: true,
                        minLength: 5,
                        maxLength: 5,
                        isNumeric: true
                    },
                    valid:false,
                    touched:false
                },
                email:{
                    elementType:'input',
                    elementConfig:{
                        type:'text',
                        placeholder:'Enter your email'
                    },
                    value:'',
                    validation:{
                        required:true,
                        isEmail: true
                    },
                    valid:false,
                    touched:false
                },
                deliveryMethod:{
                    elementType:'select',
                    elementConfig:{
                        options:[
                            {value:'fastest',displayValue:'Fastest'},
                            {value:'cheapest',displayValue:'Cheapest'}

                        ]
                    },
                    value:'',
                    validation:{},
                    valid:true
                },
        },
        formIsValid:false,
        loading:false
        
    }


    //to handle to order button
    orderHandler=(event)=>{

        // to prevent the pafe to refresh
        event.preventDefault();
        //to set the state
        this.setState({
            loading:true
        });

        //to save form data
        const formData={};
        for (let formElementIdentifier in this.state.orderForm){
            formData[formElementIdentifier]=this.state.orderForm[formElementIdentifier].value;
        }

        //to save the order details
        const order={
            ingredients:this.props.ingredients,
            price:this.props.price,
            orderData:formData
        }

        //to save the order and customer details on server
        axios.post('/orders.json',order)
            .then(response=>{
                this.setState({
                loading:false                
                });
                this.props.history.push('/');
            
            })
            .catch(error=>{
                this.setState({
                    loading:false
                });
            })
    }

    //to validate the form
    checkValidation=(value,rules)=>{
        let isValid = true;
        if (!rules) {
            return true;
        }
        
        if (rules.required) {
            isValid = value.trim() !== '' && isValid;
        }

        if (rules.minLength) {
            isValid = value.length >= rules.minLength && isValid
        }

        if (rules.maxLength) {
            isValid = value.length <= rules.maxLength && isValid
        }

        if (rules.isEmail) {
            const pattern = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
            isValid = pattern.test(value) && isValid
        }

        if (rules.isNumeric) {
            const pattern = /^\d+$/;
            isValid = pattern.test(value) && isValid
        }

        return isValid;

    }

    // to save the input tag as per the changes made
    inputChangeHandler=(event,inputIdentifier)=>{
        //for deep drilling and then taking the required data
        const updateOrderForm={
            ...this.state.orderForm
        }
        //for deep drilling and then taking the required data
        const updateFormElements={
            ...updateOrderForm[inputIdentifier]
        }

        //bbasic settings
        updateFormElements.value=event.target.value;
        updateFormElements.valid=this.checkValidation(updateFormElements.value,updateFormElements.validation);
        updateFormElements.touched=true;
        updateOrderForm[inputIdentifier]=updateFormElements;
        //for vaildations
        let formIsValid=true;
        for(let inputIdentifier in updateOrderForm){
            formIsValid=updateOrderForm[inputIdentifier].valid && formIsValid
        }
        //to set state
        this.setState({
            orderForm:updateOrderForm,
            formIsValid:formIsValid
        })

    }

    render(){
        const formElementArray=[];
        for(let key in this.state.orderForm){
            formElementArray.push({
                id:key,
                config:this.state.orderForm[key]
            })
        }
        let form=(
            <form onSubmit={this.orderHandler}>
            {formElementArray.map(formElement=>(
                <Input 
                    key={formElement.id}
                    elementType={formElement.config.elementType}
                    elementConfig={formElement.config.elementConfig}
                    value={formElement.config.value}
                    inValid={!formElement.config.valid}
                    shouldValidate={formElement.config.validation}
                    touched={formElement.config.touched}
                    changed={(event)=>this.inputChangeHandler(event,formElement.id)}/>
            ))}
            <Button btnType="Success" disabled={!this.state.formIsValid} >ORDER</Button>

        </form>
        );
        if(this.state.loading)
        {
            form=<Spinner/>
        }
        return(
            <div className={classes.ContactData}>
                <h4>Enter your contact details:-</h4>
                {form}

            </div>
        );
    };
}
export default ContactData;