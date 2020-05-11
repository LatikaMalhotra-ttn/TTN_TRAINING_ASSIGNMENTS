import React from 'react'
import classes from './NavigationItems.module.css';
import NavigationItem from './NavigationItem/NavigationItem'



// functional component which wraps all the tabs of navigation bar
const navigationItems= (props) => (
    <ul className={classes.NavigationItems}>
        <NavigationItem link="/" exact>Burger Builder</NavigationItem>
        <NavigationItem link="/orders">Orders</NavigationItem>
    </ul>
);

export default navigationItems;