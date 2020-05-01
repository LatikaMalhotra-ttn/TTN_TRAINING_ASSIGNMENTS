import React from 'react';
import classes from './FruitsTable.css';

const fruitsTable = (props) => {
  const list = props.list;

  const fruitsList = list.map((fruit) => {
    return <tr key={fruit.id}>
      <td>{fruit.fruit_name}</td>
      <td>{fruit.quantity}</td>
      <td>
        <button className={classes.edit} onClick={() => props.editFruit(fruit.id)}>
          { props.editMode ? "Editing.." : "Edit" }
        </button>
        <button className={classes.delete} onClick={() => props.deleteFruit(fruit.id)}>
          Delete
        </button>
      </td>
    </tr>
  });

  return (
    <div className={classes.App}>
      <table className={classes.featuresTable}>
        <thead>
          <tr>
            <th>Fruit-Name</th>
            <th>Quantity</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {fruitsList}
        </tbody>
      </table>
    </div>
  )
}

export default fruitsTable;