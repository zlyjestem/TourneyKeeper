import React, { Component } from 'react'
import './App.css'
import axios from 'axios'


class Button extends Component {
  render() {
    return (
      <button className='button' onClick={this.props.onclick}>
        Get tourney
      </button>
    );
  }
}

const TourneyCard = (props) => {
  return (
    <div className='tournament-box'>
      <div style= {{display: 'inline'}}>
        <div style={{ fontSize: '1.25em', fontWeight: 'bold' }}>Name: {props.tournamentName}</div>
        <div>Id: <span>{props.id}</span></div>
      </div>
      <div>
        <div style={{ width: '40%', textAlign: 'center' }}> {props.description} </div>
        {props.ifTopCut && <h5>Top Cut</h5>}
      </div>
    </div>

  );
};

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
        < Button onclick={this.handleClick} />
        < TourneyCard {...this.state} />
      </div>


    )
  }


}

export default App