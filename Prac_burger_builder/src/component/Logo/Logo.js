import React from "react";
import LogoSrc from "../../assets/burgerIcon.png";
import classes from "./Logo.module.css";

//class component to set the logo of the application
class Logo extends React.Component{

    render(){
        return(
            <img className={classes.Logo} src={LogoSrc} alt=" "/>
        
        )
    }

}

export default Logo;