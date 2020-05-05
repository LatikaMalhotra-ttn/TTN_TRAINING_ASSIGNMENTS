import React,{Component} from 'react'

import classes from './Model.module.css'
import Aux from '../../../hoc/Auxilary/Auxilary'
import BackDrop from '../../UI/BackDrop/BackDrop'

class Model extends Component{

    shouldComponentUpdate(nextProps,nextState){
        if(nextProps.show!==this.props.show){
            return true;
        };
    };


    componentWillUpdate(){
        console.log("[Model] Will Update");
    }

    render(){
        return(
            <Aux>
                <BackDrop show={this.props.show} clicked={this.props.modelClosed}/>
                <div className={classes.Modal}
                    style={{
                        transform:this.props.show?'translateY(0)':'translateY(-100vh)',
                        opacity:this.props.show?'1':'0'
                    }}>
                    {this.props.children}
                </div>
                
            </Aux>

        );
    };
} ;

export default Model;
