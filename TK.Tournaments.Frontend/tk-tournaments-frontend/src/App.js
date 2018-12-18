import React, { Component } from 'react'
import './App.css'
import axios from 'axios'
import TourneyCard from './components/TourneyCard'
//import Button from './components/Button'


class Button extends Component {
  render() {
    return (
      <button className='button' onClick={this.props.onclick}>
        Get tourney
      </button>
    );
  }
}

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
    axios.get('http://localhost:50434/api/tournaments/1')
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
        < Button onclick={this.handleClick} />
        < TourneyCard {...this.state} />
      </div>
    )
  }


}

export default App