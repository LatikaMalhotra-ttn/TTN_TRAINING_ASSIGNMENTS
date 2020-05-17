import * as actionTypes from '../actions/actionTypes'
import {updateObject} from '../Utility'


//initializing the initial state
const initialState={
    ingredients:null,
    totalPrice:30,
    error:false,
    building:false
}



// to set price of each ingrediant globally
const INGREDIANT_PRICE={
    salad:5,
    cheese:10,
    bacon:15,
    meat:20

}

const addIngredient=(state,action)=>{
    const updatedIngredient={[action.ingredientName]:state.ingredients[action.ingredientName]+1};
    const updateIngredients=updateObject(state.ingredients,updatedIngredient);
    const updateState={
        ingredients:updateIngredients,
        totalPrice:state.totalPrice+INGREDIANT_PRICE[action.ingredientName],
        building:true
    };
    return updateObject(state,updateState);
}

const removeIngredient=(state,action)=>{
    const updatedIng={[action.ingredientName]:state.ingredients[action.ingredientName]-1};
    const updateIngs=updateObject(state.ingredients,updatedIng);
    const updateSt={
        ingredients:updateIngs,
        totalPrice:state.totalPrice+INGREDIANT_PRICE[action.ingredientName],
        building:true
    };
    return updateObject(state,updateSt);
}

const setIngredients=(state,action)=>{
    return updateObject(state,{
        ingredients:{
            salad:action.ingredients.salad,
            meat:action.ingredients.meat,
            cheese:action.ingredients.cheese,
            bacon:action.ingredients.bacon

        },
        totalPrice:30,
        error:false,
        building:false
    });
}

const fectIngredientsFailed=(state,action)=>{
    return updateObject(state,{error:true});
}
//reduce function which is responsible to fetch the action and manipulate the state synchronously
const reducer=(state=initialState,action)=>{
    switch(action.type){
        case actionTypes.ADD_INGREDIENT: return addIngredient(state,action);
        case actionTypes.REMOVE_INGREDIENT: return removeIngredient(state,action);
        case actionTypes.SET_INGREDIENTS: return setIngredients(state,action);
        case actionTypes.FETCH_INGREDIENTS_FAILED: return fectIngredientsFailed(state,action);
        default: return state;
    }

}

export default reducer;