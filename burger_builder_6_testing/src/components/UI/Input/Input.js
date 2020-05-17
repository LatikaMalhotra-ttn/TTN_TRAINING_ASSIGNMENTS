import React from 'react'
import classes from './Input.module.css';


//generalized fynction component for input tag
const input =(props)=>{
    let inputElement=null;
    const inputClasses=[classes.InputElement];


    //to check the validation of input box
    if(props.inValid && props.shouldValidate && props.touched){
        inputClasses.push(classes.InValid);
    }


    //sqitch case to see which type of input tag is used
    switch(props.elementType){
        case('input'):
            inputElement=<input onChange={props.changed} className={inputClasses.join(' ')} {...props.elementConfig} value={props.value}/>
            break;
        case('textarea'):
            inputElement=<textarea onChange={props.changed} className={inputClasses.join(' ')} {...props.elementConfig} value={props.value}/>
            break;
        case('select'):
            inputElement=<select onChange={props.changed} className={inputClasses.join(' ')} value={props.value}>
                            {props.elementConfig.options.map(option=>(
                                <option key={option.value}  onChange={props.change}value={option.value}>
                                    {option.displayValue}
                                </option>
                            ))}
                         </select>
            break;
        default:
            inputElement=<input className={classes.InputElement} {...props.elementConfig} value={props.value}/> 
    }

    return(
        // returning the dynamic type label and input tag
        <div className={classes.Input}>
            <label className={classes.Label}>{props.label}</label>
            {inputElement}
        </div>
    )
}


export default input;