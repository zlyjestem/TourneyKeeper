import React, { Component } from 'react'
import './App.css'
import axios from 'axios'


class App extends Component {
  constructor() {
    super()
    this.state = {
      id: '',
      tournamentName: '',
      description: '',
      ifTopCut: false
    }
    this.handleClick = this.handleClick.bind(this)
  }


  handleClick() {
    axios.get('http://localhost:50434/api/tournaments/2')
      .then(response => this.setState({
        tournamentName: response.data.name,
        id: response.data.id,
        description: response.data.description,
        ifTopCut: response.data.ifTopCut
      })).catch()
  }

  render() {
    return (
      <div>
        <div className='button__container'>
          <button className='button' onClick={this.handleClick}>Click Me</button>
        </div>
        <div className='tournament-box'>
          <p>Name: {this.state.tournamentName}</p>
          <div>Id: <span>{this.state.id}</span></div>
          <p>{this.state.description}</p>
          {this.state.ifTopCut && <h5>Top Cut</h5>}
        </div>
      </div>

    )
  }


}

export default App