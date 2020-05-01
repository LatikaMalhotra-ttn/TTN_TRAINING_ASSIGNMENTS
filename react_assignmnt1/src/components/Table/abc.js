import React from 'react'

const test=(props)=>{
    return(
        <tr>
            <td>{props.name}</td>
            <td>{props.quantity}</td>
                <td>
                    <input type="submit" value="Delete"/>|
                    <input type="submit" value="Edit"/>
            </td>
        </tr>
    )
}

export default test;