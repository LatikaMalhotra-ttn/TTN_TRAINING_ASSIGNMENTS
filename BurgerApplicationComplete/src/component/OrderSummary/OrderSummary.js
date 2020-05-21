import React , {Component} from "react";
import classes from "./OrderSummary.module.css";
import CheckoutButton from "../Button/Button";
import Backdrop from "../Backdrop/Backdrop";
import shortid from 'shortid';

class OrderSummary extends Component{

    checkoutHandler = ()=>{
    
        this.props.checkout()
    }
    
    render(){
      let listValues=  Object.keys(this.props.ingredientsList).map((ingredientName)=>{
                            if(ingredientName!=="BreadTop" && ingredientName!=="BreadBottom"
                                 && this.props.ingredientsList[ingredientName]>0)
                            {
              
                                return(
                                    <li key={shortid.generate()} 
                                        className={classes.ListItem }>
                                            <p className={classes.ChildItem }>
                                                {ingredientName}
                                            </p>
                                            <p className={classes.ChildItem}>
                                                x{this.props.ingredientsList[ingredientName]}
                                            </p> 
                                    </li>
                                )
                            }
                            else{
                                return null;
                            }
        })




        return(
            <React.Fragment>
                
                <Backdrop backdropClick={this.props.backdropClick}/>
            
            <div className={classes.OrderSummaryContainer + " text-dark text-monospace"}>
            
                <strong style={{textDecoration:"underline"}}>Order Summary</strong>
                <p >A delicious Burger with following ingredients :</p>
                  
                <ul>
                {
                            listValues
                    }
                </ul>
                <p><strong>Total Price: </strong>Rs {this.props.totalPrice} /-</p>

                        <CheckoutButton btnClick={this.checkoutHandler} 
                        btnClassName="btn btn-warning" 
                        btnName="Checkout with items!"/>
               
                    
            </div>
            </React.Fragment>
        )
    }

}

export default OrderSummary;