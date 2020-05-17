import React from 'react'
import classes from './BuildControl.module.css'


//Here generalized function component is used so add or decrease ingridents in burger
const buildControl = (props) => (
    <div className={classes.BuildControl}>

        {/* to add the name of ingredient */}
        <div className={classes.Label}>{props.label}</div>

        {/* To add buttons for less and more */}
        <button 
            className={classes.Less} 
            onClick={props.removed}
            disabled={props.disabled}>
            Less
        </button>
        <button className={classes.More} onClick={props.added}>More</button>

    </div>
)

export default buildControl;