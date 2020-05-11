import React , {Component} from "react";
import classes from "./Backdrop.module.css";


//generalized function component for backdrop
class Backdrop extends Component{

    render(){
        return(
            <div onClick={this.props.backdropClick} className={classes.BackdropContainer}>
                
            </div>
        )
    }

}

export default Backdrop;