import React ,{Component} from 'react'

import Aux from '../../hoc/Auxilary/Auxilary'
import Burger from '../../components/Burger/Burger'
import Buildcontrols from '../../components/Burger/BuildControls/BuildControls'
import Model from '../../components/UI/Model/Model'
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary'

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
        ingredients:{
          salad:0,
          cheese:0,
          bacon:0,
          meat:0
        },
        totalPrice:30,
        purchasable:false,
        purchasing:false
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

    //to end the purchase i.e when the purchase is over
    purchaseContinueHandler=()=>{
        alert("You Continue");
    }

    render(){
        const disabledInfo={
            ...this.state.ingredients
        };
        for(let key in disabledInfo){
            disabledInfo[key]=disabledInfo[key]<=0
        }

        return(
            <Aux >
                <Model show={this.state.purchasing} 
                    modelClosed={this.purchaseCancelHandler}>
                        <OrderSummary ingredients={this.state.ingredients}
                        purchaseCancelled={this.purchaseCancelHandler}
                        purchaseContinue={this.purchaseContinueHandler}
                        price={this.state.totalPrice}/>
                </Model>
                <Burger ingredients={this.state.ingredients}/>
                <Buildcontrols
                    ingrediantAdded={this.addIngrediantHandler}
                    ingrediantRemoved={this.removeIngrediantHandler}
                    disabled={disabledInfo}
                    price={this.state.totalPrice}
                    purchasable={this.state.purchasable}
                    ordered={this.purchaseHandler}/>
            </Aux>
        )
    }
}

export default BurgerBuilder;