import React,{Component} from 'react';
import {connect} from 'react-redux';

import Order from '../../components/Order/Order';
import axios from '../../AxiosOrder';
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler';
import Spinner from '../../components/UI/Spinner/Spinner'

import * as actions from '../../Store/actions/index'


//class component for order
class Orders extends Component{

    //to get data from the server
    componentDidMount(){
        this.props.onLoadOrders(this.props.token,this.props.userId);
    }

    render(){
        let orders=<Spinner/>
        if(!this.props.loading){
            orders=(
                this.props.orders.map(order=>(
                    <Order  key={order.id}
                    ingredients={order.ingredients}
                    price={order.price}/>
                ))
            );
        }
        return(
            <div>
                {orders}
            </div>
        );
    }
}
const mapStatetoProps=state=>{
    return{
        orders:state.order.orders,
        loading:state.order.loading,
        token:state.auth.token,
        userId:state.auth.userId
    }
}

const mapDispatchToProps=dispatch=>{
    return{
        onLoadOrders:(token,userId)=>dispatch(actions.fetchOrders(token,userId))
    }
}


export default connect(mapStatetoProps,mapDispatchToProps)(withErrorHandler(Orders,axios));