import React,{Component} from 'react';
import './App.css';
import Layout from './hoc/Layout/Layout'
import BurgerBuilder from './container/BurgerBuilder/BurgerBuilder'
import CheckOut from './container/Checkout/Checkout'
import {Route,Switch} from 'react-router-dom'
import Orders from './container/Orders/Orders'

//parent component of the application
class App extends Component {


  render(){
    return (
      <div className="App">
        <Layout>
          <Switch>
            <Route path="/checkout" component={CheckOut}/>
            <Route path="/orders" component={Orders}/>
            <Route path="/" exact component={BurgerBuilder}/>
          </Switch>
          

          
        </Layout>
      </div>
    );
  }

}

export default App;
