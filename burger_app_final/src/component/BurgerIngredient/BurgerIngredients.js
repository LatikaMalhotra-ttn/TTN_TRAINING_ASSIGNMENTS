import React , {Component} from "react";
import classes from "../Burger/Burger.module.css";
import shortid from 'shortid';

class BurgerIngredients extends Component{
    
    generateKey = (pre) => {
        return `${ pre }_${ new Date().getTime() }`;
    }


    provideIngredient = (ingredientName)=>{
            switch(ingredientName){
                case ("BreadTop"):
                    return (<React.Fragment key={shortid.generate()}> 
                                <div className={classes.BreadTop}>
                        
                                    <div className={classes.Seeds1}></div>
                                    <div className={classes.Seeds2}></div>
                                </div>
                                {this.props.children}  
                                </React.Fragment>)
                case ("Meat"):
                    return <div key={shortid.generate()} className={classes.Meat}></div>
                                 

                case ("Salad"):
                    return  <div key={shortid.generate()} className={classes.Salad}></div>
                                            
                case ("Cheese"):
                    return <div key={shortid.generate()} className={classes.Cheese}></div>
                                
                case ("Bacon"):
                    return <div key={shortid.generate()}  className={classes.Bacon}></div>
                                                             
                case ("BreadBottom"):
                    return <div key={shortid.generate()} className={classes.BreadBottom}></div>
                default:
                    return <div></div>
            }
    }

    

    render(){
    
        let finalIngredientsMarkups = [];
        finalIngredientsMarkups.push(this.provideIngredient("BreadTop"))
        
        let keySet=Object.keys(this.props.ingredients)
        
        for(let i=0;i<keySet.length;i++){
            let key=keySet[i];
            let ingredientsMarkup=[];
            
            for(let j=0; j<this.props.ingredients[key];j++){
                                if(key!=="BreadTop" && key!== "BreadBottom"){
                                ingredientsMarkup.push(this.provideIngredient(key))
                            }

        }
        finalIngredientsMarkups.push(ingredientsMarkup)
    }
    finalIngredientsMarkups.push(this.provideIngredient("BreadBottom"))

    
        return(
            <React.Fragment>
            {
                finalIngredientsMarkups
                
            }
           </React.Fragment> 
        )
    }

}

export default BurgerIngredients;