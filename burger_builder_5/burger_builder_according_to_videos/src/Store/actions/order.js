import * as actionTypes from './actionTypes'
import axios from '../../AxiosOrder'


//action creator if burchase burger is successfull
export const purchaseBurgerSuccess=(id,orderData)=>{
    return{
        type:actionTypes.PURCHASE_BURGER_SUCCESS,
        orderId:id,
        orderData:orderData
    };
}
//action creator if burchase burger failed
export const purchaseBurgerFailed=(error)=>{
    return{
        type:actionTypes.PURCHASE_BURGER_FAILED,
        error:error
    };
}

//action creator if purchase burger starts
export const purchaseBurgerStart=()=>{
    return{
        type:actionTypes.PURCHASE_BURGER_START
    }
}


//action creator while purchasing burger
export const purchaseBurger=(orderData)=>{
    return dispatch=>{
                //to save the order and customer details on server
                dispatch(purchaseBurgerStart());
                axios.post('/orders.json',orderData)
                .then(response=>{
                    dispatch(purchaseBurgerSuccess(response.data.name,orderData))
                })
                .catch(error=>{
                    dispatch(purchaseBurgerFailed(error))
                    console.log("fail")
                })
                dispatch( purchaseBurgerStart() );
    }
}


//action creator to initialize purchase of burger
export const purchaseInit=()=>{
    return {
        type:actionTypes.PURCHASE_INIT
    }
}


//fetch order when purchase is successfull

export const fetchOrderSuccess=(orders)=>{
    return{
        type:actionTypes.FETCH_ORDER_SUCCESS,
        orders:orders
    }
}

//fetch order when purchase is failed
export const fetchOrderFail=(error)=>{
    return{
        type:actionTypes.FETCH_ORDER_FAILED,
        error:error
    }
}

//fetch order when purchase is started
export const fetchOrderStart=()=>{
    return{
        type:actionTypes.FETCH_ORDER_START
    }
}

//fetch orders
export const fetchOrders=()=>{
    return dispatch=>{
        dispatch(fetchOrderStart());
        axios.get("/orders.json")
        .then(res=>{
            const fetchOrders=[];
            for(let key in res.data){
                fetchOrders.push({
                    ...res.data[key],
                    id:key
                })
            }
            dispatch(fetchOrderSuccess(fetchOrders))
        })
        .catch(err=>{
            dispatch(fetchOrderFail(err));
        })
    }
}