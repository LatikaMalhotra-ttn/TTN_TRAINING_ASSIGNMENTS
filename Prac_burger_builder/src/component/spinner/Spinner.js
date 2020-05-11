import React from "react"
import classes from "./Spinner.module.css";



//generilized class componennt to handle spinner
const Spinner  = (props)=>{
    
    return(
        <div style={props.style ? props.style :null } className={classes.Ldsfacebook}><div></div><div></div><div></div></div>
    )
}
export default Spinner;