import * as actionTypes from '../actions/actionTypes'
import {updateObject} from '../Utility'


const initialState={
    orders:[],
    loading:false,
    purchasing:false
}

const purachaseInit=(state,action)=>{
    return updateObject(state,{purchase:false});
}

const purchaseBurgerStart=(state,action)=>{
    return updateObject(state,{loading:true});
}

const purchaseBurgerSuccess=(state,action)=>{
    const newOrder={
        ...action.orderData,
        id : action.orderId
    };
    return updateObject(state,{
        purchasing:true,
        loading:false,
        orders:state.orders.concat(newOrder)
    });
}

const purchaseBurgerfailed=(state,action)=>{
    return updateObject(state,{loading:false});
}

const fetchOrderStart=(state,action)=>{
    return updateObject(state,{loading:true});
}

const fetchOrderSuccess=(state,action)=>{
    return updateObject(state,{
        orders:action.orders,
        loading:false
    });
}
const fetchorderFailed=(state,action)=>{
    return updateObject(state,{loading:false});
}
const orderReducer=(state=initialState,action)=>{
    switch(action.type){
        case actionTypes.PURCHASE_INIT: return purachaseInit(state,action);  
        case actionTypes.PURCHASE_BURGER_START: return purchaseBurgerStart(state,action);
        case actionTypes.PURCHASE_BURGER_SUCCESS: return purchaseBurgerSuccess(state,action);
        case actionTypes.PURCHASE_BURGER_FAILED: return purchaseBurgerfailed(state,action);
        case actionTypes.FETCH_ORDER_START: return fetchOrderStart(state,action);
        case actionTypes.FETCH_ORDER_SUCCESS: return fetchOrderSuccess(state,action);
        case actionTypes.FETCH_ORDER_FAILED: return fetchorderFailed(state,action);
        default: return state;
    }
}

export default orderReducer;