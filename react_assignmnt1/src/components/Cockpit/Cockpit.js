import React from 'react'
import Styles from '../Cockpit/cockpit.module.css'

const cockpit = (props) =>{
    
    return(
        <div>
            <input type="text" id="inputTag" onChange={props.changed} />
            <button onClick={props.clicked}>Submit data</button>
        </div>
    );
}

export default cockpit;