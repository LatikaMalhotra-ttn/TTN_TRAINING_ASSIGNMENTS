import React ,{Component} from 'react'

import Aux from '../../hoc/Auxilary/Auxilary'
import Burger from '../../components/Burger/Burger'
import Buildcontrols from '../../components/Burger/BuildControls/BuildControls'
import Model from '../../components/UI/Model/Model'
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary'
import axios from '../../AxiosOrder'
import Spinner from '../../components/UI/Spinner/Spinner'
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler'


// to set price of each ingrediant globally
const INGREDIANT_PRICE={
    salad:5,
    cheese:10,
    bacon:15,
    meat:20

}

//class component that wraps all the component of burger builder
class BurgerBuilder extends Component{
    state={
        ingredients:null,
        totalPrice:30,
        purchasable:false,
        purchasing:false,
        loading:false,
        error:false
    }

    //to get data from the backend
    componentDidMount(){
        axios.get('https://react-my-burgur-c4e5f.firebaseio.com/ingredients.json')
            .then(response=>{
                this.setState({
                    ingredients:response.data
                });
            })
            .catch(error=>{
                this.setState({
                    error:true
                })
            });
    }
    //to update the purchase state as required i.e set to true only when some urchase is made
    updatePurchaseState(ingredients){

        //convert onbject to array and calculating sum
        const sum = Object.keys(ingredients)
                        .map(igKey=>{
                            return ingredients[igKey];
                        })
                        .reduce((sum,el)=>{
                            return sum+el;
                        },0);
        //seting state
        this.setState({
            purchasable:sum>0
        })
    }

    // to add the ingredients as added by the user
    addIngrediantHandler=(type)=>{
        const oldCount= this.state.ingredients[type];
        const updateCount=oldCount+1;
        const updatedIngredients={
            ...this.state.ingredients
        };
        updatedIngredients[type]=updateCount;
        const priceAddition=INGREDIANT_PRICE[type];

        const oldPrice=this.state.totalPrice;
        const newPrice=oldPrice+priceAddition;

        this.setState({
            ingredients:updatedIngredients,
            totalPrice:newPrice
        });

        this.updatePurchaseState(updatedIngredients);
    }

    // to remove state as said by the user

    removeIngrediantHandler=(type)=>{
        const oldCount= this.state.ingredients[type];
        if(oldCount<=0){
            return ;
        }
        const updateCount=oldCount-1;
        const updatedIngredients={
            ...this.state.ingredients
        };
        updatedIngredients[type]=updateCount;
        const priceDeduction=INGREDIANT_PRICE[type];

        const oldPrice=this.state.totalPrice;
        const newPrice=oldPrice - priceDeduction;

        this.setState({
            ingredients:updatedIngredients,
            totalPrice:newPrice
        });

        this.updatePurchaseState(updatedIngredients);
    }

    // to set the state

    purchaseHandler=()=>{
        this.setState({
            purchasing:true
        })
    }
    // to set the state
    purchaseCancelHandler=()=>{
        this.setState({
            purchasing:false
        })
    }

    //to end the purchase i.e when the purchase is over(http post request is fired using axios)
    purchaseContinueHandler=()=>{
        this.setState({
            loading:true
        })
        const order={
            ingredients:this.state.ingredients,
            price:this.state.totalPrice,
            customer:{
                Name:'Latika Malhotra',
                Age:23,
                Address:{
                    city:'New Delhi',
                    state:'Delhi',
                    country:'India',
                    PinCode:110018

                },
                email:'l@tothenew.com'
            }
        }
        axios.post('/orders.json',order)
        .then(response=>{
            // console.log(response)
            this.setState({
                loading:false,
                purchasing:false
            });
            
        })
        .catch(error=>{
            // console.log(error);
            this.setState({
                loading:false,
                purchasing:false
            });
        })
    }

    render(){
        const disabledInfo={
            ...this.state.ingredients
        };
        for(let key in disabledInfo){
            disabledInfo[key]=disabledInfo[key]<=0
        }
        //to render orderSummery only when we have data

        let orderSummery=null;



        //to render Burgur component only when we have data
        let burgur =this.state.error?<p>Can't resolve error>please try later</p>:<Spinner/>;
        if(this.state.ingredients){
            burgur=(<Aux>
                <Burger ingredients={this.state.ingredients}/>
                <Buildcontrols
                    ingrediantAdded={this.addIngrediantHandler}
                    ingrediantRemoved={this.removeIngrediantHandler}
                    disabled={disabledInfo}
                    price={this.state.totalPrice}
                    purchasable={this.state.purchasable}
                    ordered={this.purchaseHandler}/>
                </Aux>);
            orderSummery=<OrderSummary ingredients={this.state.ingredients}
                            purchaseCancelled={this.purchaseCancelHandler}
                            purchaseContinue={this.purchaseContinueHandler}
                            price={this.state.totalPrice}/>
        }
        
        if(this.state.loading){
            orderSummery=<Spinner/>
        }
        return(
            <Aux >
                <Model show={this.state.purchasing} 
                    modelClosed={this.purchaseCancelHandler}>
                    {orderSummery}
                </Model>
                {burgur}
            </Aux>
        )
    }
}

export default withErrorHandler(BurgerBuilder,axios);