import React,{Component} from 'react'
import Aux from '../Auxilary/Auxilary'
import Toolbar from '../../components/Navigation/Toolbar/Toolbar'
import classes from './Layout.module.css'
import SideDrawer from '../../components/Navigation/SideDrawer/SideDrawer'


// class component that set the layout of the whole application
class Layout extends Component{
    state={
        showSideDrawer:false
    };


    //set state for side drawer
    sideDrawerClosedHandler=()=>{
        this.setState({
            showSideDrawer:false
        });
    };

    //set toggle for drawer button

    sideDrawerToggleHandler=()=>{
        this.setState((prevState)=>{return{
            showSideDrawer:!prevState.showSideDrawer
        };
            
        });
    }

    render(){
        return(
            <Aux>
                <Toolbar drawerToggledClicked={this.sideDrawerToggleHandler}/>
                <SideDrawer closed={this.sideDrawerClosedHandler} open={this.state.showSideDrawer}/>
                <main className={classes.Content}>
                    {this.props.children}
                </main>
            </Aux>
        );
    };
} ;
export default Layout;

