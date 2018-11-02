import React, { Component } from 'react'
import './App.css'
import axios from 'axios'


class App extends Component {
  constructor () {
    super()
    this.state = {
      id: '',
      tournamentName: ''
    }
    this.handleClick = this.handleClick.bind(this)
  }

  handleClick () {
    axios.get('http://localhost:50434/api/tournaments/1')
      .then(response => this.setState({tournamentName: response.data.name, id: response.data.id})).catch()
  }

  render () {
    return (
      <div className='button__container'>
        <button className='button' onClick={this.handleClick}>Click Me</button>
        <p>Name: {this.state.tournamentName}</p>
        <div>Id:<span>{this.state.id}</span></div>
    
      </div>
      
    )
  }
}

export default App