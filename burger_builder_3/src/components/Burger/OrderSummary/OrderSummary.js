import React,{Component} from 'react'

import Aux from '../../../hoc/Auxilary/Auxilary'
import Button from '../../UI/Button/Button'


//class componont to display the order summery
class OrderSummary extends Component{

    //to see if this component is renderd everting prop or state is changed 
    componentWillUpdate(){
        console.log("[orderSummary will update]");
    }

    render(){

        //converting object to array and then add it to list
        const ingredientsSummary=Object.keys(this.props.ingredients)
        .map(igKey=>{
            return (
                <li key={igKey}>
                    <span 
                        style={{textTransform:"capitalize"}}>
                        {igKey}
                    </span> 
                    : {this.props.ingredients[igKey]}
                </li>
            );
        });

        return(
            <Aux>
                <h3>Your Order</h3>
                <p>Your burger has following ingrediants:-</p>
                {/* Add data in the list */}
                <ul>
                    {ingredientsSummary}
                </ul>
                <p><strong>Total Price :Rs {this.props.price.toFixed(2)}</strong></p>
                <p>Continue to checkout!!</p>

                {/* Button to canel or continue the order */}
                <Button btnType="Danger" clicked={this.props.purchaseCancelled}>CANCEL</Button>
                <Button btnType="Success" clicked={this.props.purchaseContinue}>CONTINUE</Button>
            </Aux>
        
        );
    };
}


export default OrderSummary;