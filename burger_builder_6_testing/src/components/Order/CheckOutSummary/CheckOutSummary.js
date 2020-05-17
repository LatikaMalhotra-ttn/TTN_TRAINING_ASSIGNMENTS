import React from 'react'
import Burger from '../../Burger/Burger'
import Button from '../..//UI/Button/Button'
import classes from './CheckOutSummary.module.css'



//function component for checkout summery
const checkOutSummary = (props)=>{
    return(
        <div className={classes.CheckOutSummary}>
            <div style={{width:'100%',margin:'auto'}}>
                <Burger ingredients={props.ingredients}/>
            </div>
            <div className={classes.But}>   
            <Button 
                btnType="Danger"
                clicked={props.checkoutCancel}>CANCEL</Button>
            <Button 
                btnType="Success"
                clicked={props.checkoutContinue}>CONTINUE</Button>

            </div>

        </div>

    );
} ;


export default checkOutSummary;