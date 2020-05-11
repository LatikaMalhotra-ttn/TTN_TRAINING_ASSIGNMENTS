import React, { Component } from 'react';


// generalised class component to return child prop of parent
class BlockData extends Component {

  render() {
    return (
      <div >
        {this.props.children}
      </div>
    );
  }
}

export default BlockData;
