import React,{Component} from 'react'
import {connect} from 'react-redux'
import CheckOutSummery from '../../components/Order/CheckOutSummary/CheckOutSummary'
import {Route} from 'react-router-dom'
import ContactData from '../../container/Checkout/ContactData/ContactData' 


//class component for the checkout 
class Checkout extends Component{

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
                    ingredients={this.props.ings}
                    checkoutCancel={this.checkoutCancelHandler}
                    checkoutContinue={this.checkoutContinueHandler}>
                
                </CheckOutSummery>
                <Route 
                    path={this.props.match.path + '/contact-data'} 
                    component={ContactData}/>
            </div>
        );
    }
}


const mapStateToProps=(state)=>{
    return{
        ings:state.ingredients

    }
}
export default connect(mapStateToProps)(Checkout);