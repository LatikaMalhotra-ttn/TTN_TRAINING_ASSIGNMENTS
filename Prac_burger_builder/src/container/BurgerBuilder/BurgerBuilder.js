import React , {Component} from "react";
import Burger from "../../component/Burger/Burger"
import classes from "../BurgerBuilder/BurgerBuilder.module.css"
import BurgerIngredientController from "../../container/BurgerBuilder/IngredientController/IngredientController"
import BurgerPrice from "../../component/BurgerPrice/BurgerPrice"
import OrderNow from "../../component/Button/Button"
import OrderSummary from "../../component/OrderSummary/OrderSummary"
import Sidedrawer from "../../component/SideDrawer/Sidedrawer"
import axios from "../BurgerBuilder/axios"
import Spinner from "../../component/spinner/Spinner"
import SuccessAlert from "../../component/alert/Alert"
import Backdrop from "../../component/Backdrop/Backdrop"
import UserDetailForm from "../orderForm/OrderUserDetail"
import withErrorHandler from "../../component/ErrorHandler/withErrorHandler"


//class component for burger builder
class BurgerBuilder extends Component{


    //get ingredients from the server
    componentDidMount(){
        axios.get("ingredients.json")
        .then(res=>{
            
            this.setState({ingredients:res.data})
            this.initialState.ingredients={...res.data}
          
        })
        .catch(error=>{
            
                this.props.verifyErrorOccur(error)
        })
    }

    total=0;

    //set the state for thhe price and the state management of the components
    state = {
        orderPlaced:false,
        checkedOut:false,
        orderInPlace:false,
        price:{
            BreadTop:0,
            Salad:10,
            Bacon:30,
            Cheese:80,
            Meat:100,
            BreadBottom:0
        },
        totalPrice:0,
        orderNowClickedStatus:false,
        orderNowClickEligible:false,
        backdropVisible:false
        
        
         
    }

        
    initialState={...this.state}

    // for checkout ->the states are to be changed
    checkout=()=>{
        this.setState({orderNowClickedStatus:false,checkedOut:true})
    }


    //to calculate the price

    findPrice = ()=>{
        this.setState((prevState)=>{
            let total = Object.keys(prevState.price).map((key)=>{
                if(key!="BreadTop" && key!="BreadBottom"){
                let ingredientNumber = Number(prevState.ingredients[key])
                let ingredientPrice = Number(prevState.price[key])
                 this.total+= ingredientNumber * ingredientPrice;
                }
                
            })
    
            
            this.setState((prevState2)=>{
                    return {totalPrice:this.total}
            },()=>{
               this.total=0
            })

        })
       
    
    }

    //to check if any of the ingredients is selected  or not

    checkIfAnySelected= ()=>{
        
        if(this.state.ingredients.Bacon===0 && this.state.ingredients.Salad===0 &&
            this.state.ingredients.Meat===0 && this.state.ingredients.Cheese===0 )
            {
            
                return false;
            }

            return true;
    }



    //add ingrediennts in the burger
    addIngredient = (e)=>{
            let keyIs = e.target.parentNode.id
            if(this.state.ingredients[keyIs]<3){
                this.setState((prevState)=>{
                    prevState.ingredients[keyIs]+=1;
                    return {ingredients:prevState.ingredients}
                },()=>{
                    this.findPrice()
                    this.updateOrderNowClickEligibleStatusOnAdd()
                })
            }
          
    }



    //remove ingredinets from the burger
    removeIngredient = (e)=>{
        
        let keyIs = e.target.parentNode.id
        
            
            this.setState((prevState)=>{
                if(prevState.ingredients[keyIs]>0){
                
            
                prevState.ingredients[keyIs]-=1;
                return {ingredients:prevState.ingredients}
                }
            },()=>{
                this.findPrice()
                this.updateOrderNowClickEligibleStatusOnRemove()
            })
          
}


    // update the order -> when cust is eligible

    updateOrderNowClickEligibleStatusOnAdd=()=>{
        if(this.state.orderNowClickEligible===false){
        Object.keys(this.state.ingredients).map((ingredientName)=>{
            
                if(this.state.ingredients[ingredientName]>0 && this.state.ingredients[ingredientName]!="BreadTop" && this.state.ingredients[ingredientName]!="BreadBottom"){
                    this.setState((prevState)=>{
                       return {orderNowClickEligible:true}
                    })
                }
            
        })
    }
    }

    // remove the ingredients from the burgur when cuust is eligible

    updateOrderNowClickEligibleStatusOnRemove=()=>{
        
        let ingKeys = Object.keys(this.state.ingredients);
        for(let i=0;i<ingKeys.length;i++){
            if(this.state.ingredients[ingKeys[i]] >0 && ingKeys[i]!="BreadTop" && ingKeys[i]!="BreadBottom" ){
                return 0;
            }
        }
        this.setState((prevState)=>{
            
            return {orderNowClickEligible:false}
        })
    }



    // orger button handler
    orderNow=()=>{
            this.setState(()=>{
                return {orderNowClickedStatus:true}
            })
    }


    // to handle backgrop

    backdropClickForOrder = ()=>{
        this.setState(()=>{
            return {orderNowClickedStatus:false}
        })
    }


    // to handle user detail form
    closeOrderUserDetailForm=()=>{
        this.setState({checkedOut:false})
    }

    boughtFormDetailObj={}

    // to ftech details fro the form
    bringFormDetailValues = (obj)=>{
        this.boughtFormDetailObj={...obj}

    }

    // to post user details from the form

    submitUserDetailForOrderForm=()=>{
        this.setState({orderInPlace:1,checkedOut:false})
        
        let order={
            name:this.boughtFormDetailObj.name.value,
            ingredients :{...this.state.ingredients},
            totalPrice : this.state.totalPrice,
            address:{
                street:this.boughtFormDetailObj.street.value,
                city:this.boughtFormDetailObj.city.value,
                state:this.boughtFormDetailObj.state.value,
                zipCode:this.boughtFormDetailObj.zipCode.value,
                
            },
            paymentMethod:this.boughtFormDetailObj.paymentMethod.value,
            phoneNumber:this.boughtFormDetailObj.phoneNumber.value,
            email:this.boughtFormDetailObj.email.value
            
        }

        axios.post("/order.json",order)
        .then(res=>{
            
            
            this.setState({orderInPlace:2})

            this.setState(()=>{
                this.initialState.orderInPlace=2;
                // here setting state to initial when order is completed
                return {...this.initialState}
            })
            setTimeout(()=>{
                
            this.setState({orderInPlace:0})
            
            },2000)
            


        })


        .catch((error)=>{
            this.setState({...this.initialState})
            this.props.verifyErrorOccur(error)
        })

    }


    render(){
   
        return(
            <div className={classes.BurgerBuilderContainer +" text-monospace"}>
               
                {
                    this.state.orderInPlace===1 ?<React.Fragment>  
                        <Backdrop />
                        <Spinner style={{position:"fixed",margin: "auto",zIndex:"151",
                        left: "0",
                        right: "0"}} />

                </React.Fragment>
                    :
                    this.state.orderInPlace===2 ? 
                    <SuccessAlert imgName="successGreen.png" type={"dark"} msg={"Order Placed !!"} />
                    :null
                }
                
                {
                    this.state.ingredients ? this.checkIfAnySelected()?<div className={classes.AroundBurger}> <Burger ingredients = {this.state.ingredients} /> </div>:
                    <div className={classes.AroundBurger}><Burger ingredients = {this.state.ingredients} ><h6>Add ingredients of your choice!</h6></Burger></div>
                    : <Spinner />
                }
                {
                    this.state.orderNowClickedStatus?
                    <OrderSummary  checkout={this.checkout} totalPrice={this.state.totalPrice} backdropClick={this.backdropClickForOrder} cancelCheckout={this.cancelCheckout} ingredientsList={this.state.ingredients} totalPrice={this.state.totalPrice}/>
                    : null
                }
                <BurgerPrice price={this.state.totalPrice}/>
               {
                   this.state.ingredients? <BurgerIngredientController addIngredient={this.addIngredient} ingredients={this.state.ingredients} removeIngredient={this.removeIngredient}/>
                    :null
               }
               {
                    this.state.checkedOut? <React.Fragment> <Backdrop backdropClick={this.closeOrderUserDetailForm} /> <UserDetailForm giveInputValuesBack={this.bringFormDetailValues} submitForm={this.submitUserDetailForOrderForm} closeForm={this.closeOrderUserDetailForm}  heading="Enter Your Details:" submitBtnTitle="Place Order"/> </React.Fragment>:null
               }
               {

               }
                <OrderNow disabledStatus={ !this.state.orderNowClickEligible}  btnClick={this.orderNow} btnClassName="btn btn-primary" btnName="ORDER NOW"/>
            </div>
        )
    }

}

export default withErrorHandler(BurgerBuilder);