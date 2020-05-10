import React from 'react'
import classes from '../BuildControls/BuildControls.module.css';
import BuildControl from './BuildControl/BuildControl'

//const ehich will help to set controls of all the ingredients
const controls=[
    {label:'salad' ,type:'salad'},
    {label:'cheese' ,type:'cheese'},
    {label:'meat' ,type:'meat'},
    {label:'bacon' ,type:'bacon'}

];


//This is a function components which wraps all the ingridents and the the order button
const buildControls = (props) => (
        <div className={classes.BuildControls}>
            <p className={classes.p}>Current Price : Rs <strong>{props.price.toFixed(2)}</strong> </p>
            {/* using map we are converting object to array and then sending data dynamically to buildControls 
            to show all the buttons to add and decrease items */}
            {controls.map(ctrl => (
                <BuildControl 
                    key={ctrl.label} 
                    label={ctrl.label}
                    added={()=>props.ingrediantAdded(ctrl.type)}
                    removed={()=>props.ingrediantRemoved(ctrl.type)}
                    disabled={props.disabled[ctrl.type]}/>
            ))}

            {/*  Button to order the product */}
            <button 
                className={classes.OrderButton}
                disabled={!props.purchasable}
                onClick={props.ordered}>
                ORDER NOW
            </button>
        </div>
);

export default buildControls;