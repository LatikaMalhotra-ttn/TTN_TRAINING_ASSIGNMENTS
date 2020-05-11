import React from "react"
import "./Alert.css"


//generalized function component for alert
const Alert = (props)=>{
    return(
        <div style={{width:"80%",margin:"auto"}} 
             className={`alert alert-${props.type} customAlert`}>
                 <img className="alerticon" src={require(`../../assets/${props.imgName}`)} alt="server side error.please try later" /> 
                 {props.msg} 
        </div>
    )
}

export default Alert;