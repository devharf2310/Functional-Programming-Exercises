import React from 'react';
import logo from './logo.svg';
import Person from './Person';

class App extends React.Component {
  
  constructor(){
    this.state = {
      Name: "Julio Avellaneda"
    };
  }

  render= () =>{
    this.state = "HUgo";
    return(
      <Person/>
    )
  }
  
}

export default App;
