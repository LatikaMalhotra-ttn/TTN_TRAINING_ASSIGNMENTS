import React,{Component} from 'react';
import './App.css';
import Layout from './hoc/Layout/Layout'
import BurgerBuilder from './container/BurgerBuilder/BurgerBuilder'

//parent component of the application
class App extends Component {


  render(){
    return (
      <div className="App">
        <Layout>
          <BurgerBuilder/>
        </Layout>
      </div>
    );
  }

}

export default App;
