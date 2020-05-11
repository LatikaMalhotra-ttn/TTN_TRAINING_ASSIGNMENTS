import React from 'react'

import classes from '../Burger/Burger.module.css'
import BurgerIngredient from '../Burger/BurgerIngredient/BurgerIngredient'

//function component which will wrap the whole burgur together
const burger = (props) =>{

    //converting object to array using map and then flattening the array so as to get array of all ingrediants added
    let transformedIngredients=Object.keys(props.ingredients)
                                  .map(igKey =>{
                                    return [...Array(props.ingredients[igKey])]
                                    .map((_,i)=>{
                                        return <BurgerIngredient key={igKey+i} type={igKey}/>
                                    });
                                  }).reduce((arr,el)=>{
                                    return arr.concat(el);
                                  },[]);

    // to check if any ingrediant is added or not
    if(transformedIngredients.length===0){
        transformedIngredients=<p>Please start adding ingredients</p>
    }

    return(
        <div className={classes.Burger}>
            <BurgerIngredient type='bread-top' />
            {transformedIngredients}
            <BurgerIngredient type='bread-bottom' />

        </div>
    );
}

export default burger;