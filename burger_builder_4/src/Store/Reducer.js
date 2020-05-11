import * as actionTypes from './Actions'


//initializing the initial state
const initialState={
    ingredients:{
        salad:0,
        meat:0,
        bacon:0,
        cheese:0
    },
    totalPrice:30,
}



// to set price of each ingrediant globally
const INGREDIANT_PRICE={
    salad:5,
    cheese:10,
    bacon:15,
    meat:20

}

//reduce function which is responsible to fetch the action and manipulate the state synchronously
const reducer=(state=initialState,action)=>{
    switch(action.type){
        case actionTypes.ADD_INGREDIENT:
            return {
                ...state,
                ingredients:{
                    ...state.ingredients,
                    [action.ingredientName]:state.ingredients[action.ingredientName]+1
                },
                totalPrice:state.totalPrice+INGREDIANT_PRICE[action.ingredientName]

            };
        case actionTypes.REMOVE_INGREDIENT:
            return{
                ...state,
                ingredients:{
                    ...state.ingredients,
                    [action.ingredientName]:state.ingredients[action.ingredientName]-1
                },
                totalPrice:state.totalPrice+INGREDIANT_PRICE[action.ingredientName]


            };
        default:
            return state;
    }

}

export default reducer;