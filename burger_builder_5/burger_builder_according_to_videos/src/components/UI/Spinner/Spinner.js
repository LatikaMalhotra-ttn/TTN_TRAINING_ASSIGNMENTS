import React from 'react'
import classes from './Spinner.module.css'



//generalizedd spinner function component for spinner
const spinner=()=>{
    return(
        <div className={classes.Loader}>Loading...</div>
    );

}

export default spinner;