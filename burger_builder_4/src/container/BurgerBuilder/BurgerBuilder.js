import React ,{Component} from 'react'
import {connect} from 'react-redux'

import Aux from '../../hoc/Auxilary/Auxilary'
import Burger from '../../components/Burger/Burger'
import Buildcontrols from '../../components/Burger/BuildControls/BuildControls'
import Model from '../../components/UI/Model/Model'
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary'
import axios from '../../AxiosOrder'
import Spinner from '../../components/UI/Spinner/Spinner'
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler'
import * as actionTypes from '../../Store/Actions'



//class component that wraps all the component of burger builder
class BurgerBuilder extends Component{
    state={
        purchasable:false,
        purchasing:false,
        loading:false,
        error:false
    }

    //to get data from the backend
    componentDidMount(){
        console.log(this.props);

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
        return sum>0;
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

        this.props.history.push('/checkout');
    }

    render(){
        const disabledInfo={
            ...this.props.ings
        };
        for(let key in disabledInfo){
            disabledInfo[key]=disabledInfo[key]<=0
        }
        //to render orderSummery only when we have data

        let orderSummery=null;



        //to render Burgur component only when we have data
        let burgur =this.state.error?<p>Can't resolve error>please try later</p>:<Spinner/>;
        if(this.props.ings){
            burgur=(<Aux>
                <Burger ingredients={this.props.ings}/>
                <Buildcontrols
                    ingrediantAdded={this.props.onIngredientAdded}
                    ingrediantRemoved={this.props.onIngredientRemove}
                    disabled={disabledInfo}
                    price={this.props.price}
                    purchasable={this.updatePurchaseState(this.props.ings)}
                    ordered={this.purchaseHandler}/>
                </Aux>);
            orderSummery=<OrderSummary ingredients={this.props.ings}
                            purchaseCancelled={this.purchaseCancelHandler}
                            purchaseContinue={this.purchaseContinueHandler}
                            price={this.props.price}/>
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


const mapStateToProps=state=>{
    return{
        ings:state.ingredients,
        price:state.totalPrice
    };
};

const mapDispatcherToProps=dispatch=>{
    return{
        onIngredientAdded:(ingName)=>dispatch({type:actionTypes.ADD_INGREDIENT,ingredientName:ingName}),
        onIngredientRemove:(ingName)=>dispatch({type:actionTypes.REMOVE_INGREDIENT,ingredientName:ingName})

    }
}

export default connect(mapStateToProps,mapDispatcherToProps)(withErrorHandler(BurgerBuilder,axios));