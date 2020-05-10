import React from 'react'


import Logo from '../../Logo/Logo'
import NavigationItems from '../NavigationItems/NavigationItems'
import classes from './SideDrawer.module.css'
import Aux from  '../../../hoc/Auxilary/Auxilary'
import BackDrop from '../../UI/BackDrop/BackDrop'


//function component for side drawer
const sideDrawer = (props) =>{
    let attachClasses=[classes.SideDrawer,classes.Close];

    //only open in mobile mode
    if(props.open){
        attachClasses=[classes.SideDrawer,classes.Open];
    }

    return(
        <Aux>
            <BackDrop show={props.open} clicked={props.closed}/>
            <div className={attachClasses.join(' ')}>
                <div className={classes.Logo}>
                    <Logo />
                </div>
                
                <nav>
                    <NavigationItems/>
                </nav>
            </div>            
        </Aux>

    );
}

export default sideDrawer;