import React from "react"
import {NavLink} from "react-router-dom"
import classes from "./NavigationToolbar.module.css";
import Backdrop from "../Backdrop/Backdrop"
import Auth from "../auth/Auth"
import {Redirect} from "react-router-dom"
import {connect} from "react-redux"

const actions = require("../../actions/actions")


class NavigationToolbar extends React.Component{

    state={
        loggedout:false
    }

    logoutRevised = ()=>{
            this.props.logout();
            this.setState({
                loggedout:true
            })
           
            

        }
    render()
    { 

        
        return(
            <div className={classes.NavOfToolbarContainer}>
                {
                    this.state.loggedout ? <Redirect to="/" /> : null
                }
                    
                    <p > 
                        <NavLink 
                    
                            onClick={this.props.mobileView!==undefined?()=>this.props.closeMenu():null} 
                            className={classes.Navlinks}   
                            exact to="/">
                                Build Burger
                        </NavLink>
                    </p>
                  
                  {
                      this.props.authenticated? 
                      <p>    
                        <NavLink 
                            onClick={this.props.mobileView!==undefined?()=>this.props.closeMenu():null} 
                            className={classes.Navlinks}   
                            exact to="/my-orders">
                                My Orders
                        </NavLink>
                      </p>
                      :null
                  }
                  {
                      this.props.authenticated? 
                      <p className={classes.LoginLink +" bg bg-danger"} 
                          onClick={ this.logoutRevised}>
                              Logout
                      </p>
                      :
                      <p className={classes.LoginLink +" bg bg-success"} 
                            onClick={ this.props.toggleAuthPage}>
                            Login
                      </p>

                 
                   
                  }
                   
        
        {
            this.props.auth? 
                <React.Fragment>
                    <Backdrop backdropClick={this.props.toggleAuthPage} /> 
                         <Auth toggleAuthPage={this.props.toggleAuthPage} />

                </React.Fragment>
            : null
        }
            </div>
        )
    }
}





const mapStateToProps = (state)=>{
    
    return{
        authenticated:state.authReducer.authenticated,
        username:state.authReducer.username
}
}

const mapDispatchToProps = (dispatch)=>{
    return{
     setUserAuthDetails:(authDetail)=> dispatch(actions.setUserAuthDetailsAction(authDetail)),
     logout:()=> dispatch(actions.logoutUserAction())
   
}
}


export default connect(mapStateToProps,mapDispatchToProps)(NavigationToolbar)
