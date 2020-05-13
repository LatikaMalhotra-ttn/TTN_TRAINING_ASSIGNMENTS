import * as actionTypes from './actionTypes'
import axios from '../../AxiosOrder'


//action creater for add ingredients
export const addIngredients =(ingName)=>{
    return{
        type:actionTypes.ADD_INGREDIENT,
        ingredientName:ingName
    }

}

//action creater for remove ingredients
export const removeIngredients =(ingName)=>{
    return{
        type:actionTypes.REMOVE_INGREDIENT,
        ingredientName:ingName
    }

}

//action creater to set ingredients
export const setIngredients=(ingredients)=>{
    return{
        type:actionTypes.SET_INGREDIENTS,
        ingredients:ingredients
    }
}

//action creater if fetch ingredients failed
export const fetchIngredientsFailed=()=>{
    return{
        type:actionTypes.FETCH_INGREDIENTS_FAILED,

    }
}


export const initIngredients=(ingredients)=>{
    return dispatch=>{
        axios.get('https://react-my-burgur-c4e5f.firebaseio.com/ingredients.json')
            .then(response=>{
                dispatch(setIngredients(response.data));
            })

            .catch(error=>{
                dispatch(fetchIngredientsFailed());
                
            })

    }
}