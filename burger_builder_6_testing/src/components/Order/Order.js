import React  from 'react'
import classes from './Order.module.css'


//functional component fro order
const order=(props)=>{
    const ingredients=[];

    //looping to get the name of the ingredient and amount of ingredient
    for(let ingregientsName in props.ingredients){
        ingredients.push({
            name:ingregientsName,
            amount:props.ingredients[ingregientsName]
        });
    }


    //flattening the object to array
    const ingredientOutput=ingredients.map(ig=>{
        return <span 
                style={{
                    textTransform:'capitalize',
                    display:'inline-block',
                    margin:'0 8px',
                    border:'1px solid #ccc',
                    padding:'5px'
                }}
                key={ig.name}>{ig.name} ({ig.amount})</span>
    })
    return(

        <div className={classes.Order}>
            <p><strong>Ingredients : </strong>{ingredientOutput}</p>
            <p>Price:<strong>Rs {props.price}</strong></p>

        </div>
    );
}


export default order;