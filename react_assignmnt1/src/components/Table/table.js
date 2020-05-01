import React from 'react'

const tableComp = () => {

    const renderTableData=()=> {  
        let arr=[1,2,3];
        let arr1=[23,34,56];

        let table=[];

        if(arr1.length>0){
            for(var i=0;i<=arr1.length;i++)
            {
                  let data=  
                    `<tr key=${arr[i]}>
                        <td>${arr1[i]}</td>
                        
                        <td>
                            <input type="submit" value="Delete"/>|
                            <input type="submit" value="Edit"/>
                        </td>
                    </tr>`
                table.push(data);
            }
        }
        return table;
        
    }


    return(
        <div>
            <h1>The data you have enetered is:-</h1>
            <table>
                <thead >
                    <th>Product Name</th>
                    <th>Quantity</th>
                    <th>Actions</th>
                </thead>
               <tbody>
                  {renderTableData().map((str)=> str)}
               </tbody>
            </table>
        </div>
    );
}

export default tableComp;







// import React from 'react'
// import test from './abc';

// const tableComp = (props) => {

    



//     // const renderTableData=()=> {  
        
//     //     let table=[];
//     //     if(props.productTable.length>0){
//     //         for(var i=1;i<=props.productTable.length;i++)
//     //         {
//     //               let data=  
                       
//     //             table.push(data);
//     //         }
//     //     }
//     //     return table;
        
//     // }

//         let finalProducts=[]
//         if(props.productName.length!=undefined){
//             for(let i=0;i<props.productName.length;i++){
//                 let temp=[]
//                 temp.push(props.productName[i]);
//                 temp.push(props.productQuantity[i]);
//                 finalProducts.push(temp);
//             }
//         }



//     return(
//         <div>
//             <h1>The data you have enetered is:-</h1>
//             <table>
//                 <thead key={props.index}>
//                     <th>Product Name</th>
//                     <th>Quantity</th>
//                     <th>Actions</th>
//                 </thead>
//                <tbody>
//                   {
//                    finalProducts.map((arr)=> <test name={arr[0]} quantity={arr[1]} />)  
//                   }
//                </tbody>
//             </table>
//         </div>
//     );
// }

// export default tableComp;