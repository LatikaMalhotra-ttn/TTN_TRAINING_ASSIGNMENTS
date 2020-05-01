import React, { Component } from 'react';
import './App.css';
import Cockpit from '../components/Cockpit/Cockpit'
import TableComp from '../components/Table/table'

class App extends Component {

  state = {
    inputData:'',
    count:0,
    index: [],
    productName:[],
    productQuantity:[]
  }

  changedInputHandler = (event)=>{
    const getData=event.target.value;
    this.setState({inputData:getData});
    // console.log(this.state);
    
  }

  clickButtonHandler=()=>{
    console.log("hi");
    console.log(this.state.inputData.split("-"));
    if(this.state.inputData.split('-').length!==2){
      
      alert("Please Enter data in correct format");
    }

    else{
      const [product,quantity]=this.state.inputData.split('-');

      const productNameArr=this.state.productName.concat(product);
      const quantityNameArr=this.state.productQuantity.concat(quantity);
      
      const counterArr=this.state.index.concat(this.state.count);
      console.log(productNameArr,quantityNameArr);
      this.setState({
        index:counterArr,
        productName:productNameArr,
        productQuantity:quantityNameArr,
        count:this.state.count+1
      });
      // <TableComp
      // indexTable={counterArr}
      // productTable={productNameArr}
      // quantityTable={quantityNameArr}
      // />
      console.log(this.state,'aftercondition');
      // console.log(this.state.productName);
      // console.log(this.state.productQuantity);
      // console.log(this.state.index);
      // console.log(this.state.count);
    }

  }

  render() {

    return (
      <div className="App">
        <Cockpit
        changed={event=>this.changedInputHandler(event)}
        clicked={()=>this.clickButtonHandler()}/>
        {/* <TableComp
       indexTable={this.state.index}
       productTable={this.state.productName}
       quantityTable={this.state.productQuantity}
      /> */}
      <TableComp/>
      </div>

    );
  }
}

export default App;










// import React, { Component } from 'react';
// import './App.css';
// import Cockpit from '../components/Cockpit/Cockpit'
// import TableComp from '../components/Table/table'

// class App extends Component {

//   state = {
//     inputData:'',
//     count:0,
//     index: [],
//     products:[]
//   }

//   // changedInputHandler = (event)=>{
//   //   const getData=event.target.value;
//   //   this.setState({inputData:getData});
//   // }

//   clickButtonHandler=()=>{
//      const getData=document.getElementById("inputTag").value;
//      if(getData.includes("-")){
//       const pro=getData.split("-");
//       if(pro.length!=2){
//         alert("not valid")
//       }
//       else{
//         let temp = this.state.products;
//         temp.push(pro)
//         this.setState({products:temp})
//       }
//      }
     
//     }
           

//     // if(this.state.inputData.split('-').length!==2){
//     //   alert("Please Enter data in correct format");
//     // }
//     // else{
//     //   const [product,quantity]=this.state.inputData.split('-');
//     //   const productNameArr=this.state.productName.concat(product);
//     //   const quantityNameArr=this.state.productQuantity.concat(quantity);
//     //   const counterArr=this.state.index.concat(this.state.count);
//     //   this.setState({
//     //     index:counterArr,
//     //     productName:productNameArr,
//     //     productQuantity:quantityNameArr,
//     //     count:this.state.count+1
//     //   });
//       // <TableComp
//       // indexTable={counterArr}
//       // productTable={productNameArr}
//       // quantityTable={quantityNameArr}
//       // />
//       // console.log(this.state.productName);
//       // console.log(this.state.productQuantity);
//       // console.log(this.state.index);
//       // console.log(this.state.count);
//     }

  

//   render() {

//     return (
//       <div className="App">
//         <Cockpit
//         changed={event=>this.changedInputHandler(event)}
//         clicked={()=>this.clickButtonHandler()}/>
//         <TableComp

//        indexTable={this.state.index}
//        productName={this.state.productName}
//        productQuantity={this.state.productQuantity}
//       />
//       </div>

//     );
//   }
// }

// export default App;
