import React from 'react'
import {NavLink} from 'react-router-dom'

import classes from './NavigationItem.module.css'

//function component to add list dynamically in the navigation bar
const navigationItem =(props)=>(
    <li className={classes.NavigationItem}> 
        <NavLink 
            to={props.link}
            exact={props.exact}
            activeClassName={classes.active}>
                {props.children}
                
        </NavLink>
    </li>
);

export default navigationItem;