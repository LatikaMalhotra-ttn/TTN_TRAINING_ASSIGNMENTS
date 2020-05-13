import React,{Component} from 'react'
import {connect} from 'react-redux'
import CheckOutSummery from '../../components/Order/CheckOutSummary/CheckOutSummary'
import {Route,Redirect} from 'react-router-dom'
import ContactData from '../../container/Checkout/ContactData/ContactData' 
import * as actions from '../../Store/actions/index'


//class component for the checkout 
class Checkout extends Component{


    componentWillMount(){
        console.log("checking life cycle")
        this.props.onInitPurchase();
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
        let summery=<Redirect to="/"/>
        
        if(this.props.ings){
            const purchaseRedirect = (this.props.purchasing )? <Redirect to="/"/> : null;
            summery=(
                <div>
                        {purchaseRedirect}
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
        return summery
        
    }
}


const mapStateToProps=(state)=>{
    console.log("hi")

    console.log(state)
    return{
        ings:state.burgerBuilder.ingredients,
        purchasing:state.order.purchasing
    }
}

const mapDispatchToProps=dispatch=>{
    return{
        onInitPurchase:()=>{dispatch(actions.purchaseInit())}
    }
}
export default connect(mapStateToProps,mapDispatchToProps)(Checkout);