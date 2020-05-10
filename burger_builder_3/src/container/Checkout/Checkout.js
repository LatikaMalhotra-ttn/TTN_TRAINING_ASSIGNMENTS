import React,{Component} from 'react'
import CheckOutSummery from '../../components/Order/CheckOutSummary/CheckOutSummary'
import {Route} from 'react-router-dom'
import ContactData from '../../container/Checkout/ContactData/ContactData' 


//class component for the checkout 
class Checkout extends Component{
    state={
        ingredients:null,
        totalPrice:0

    }

    // to balance the parents state and the propo and the rl location
    componentWillMount(){
        const query=new URLSearchParams(this.props.location.search);
        const ingredients={};
        let price=0;
        for (let param of query.entries()){
            if(param[0]==='price'){
                price=param[1];
            }
            else{
                ingredients[param[0]]=+param[1]
            }
            
        }
        this.setState({
            ingredients:ingredients,
            totalPrice:price
        })
    }

    //cancel button handler
    checkoutCancelHandler=()=>{
        this.props.history.goBack();
    }

    //continue button handler
    checkoutContinueHandler=()=>{
        this.props.history.replace("/checkout/contact-data");
    }
    
    render(){
        return(
            <div>
                <CheckOutSummery 
                    ingredients={this.state.ingredients}
                    checkoutCancel={this.checkoutCancelHandler}
                    checkoutContinue={this.checkoutContinueHandler}>
                
                </CheckOutSummery>
                <Route 
                    path={this.props.match.path + '/contact-data'} 
                    render={(props)=>(<ContactData ingredients={this.state.ingredients} price={this.state.totalPrice}  {...props}/>)}/>
            </div>
        );
    }
}

export default Checkout;