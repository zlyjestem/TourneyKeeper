import React, { Component } from 'react'
import './App.css'
import axios from 'axios'
import TourneyCard from './components/TourneyCard'
import Header from './components/Header'
import { library } from '@fortawesome/fontawesome-svg-core'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faIgloo } from '@fortawesome/free-solid-svg-icons'
import {faMoneyBill} from '@fortawesome/free-solid-svg-icons'

library.add(faIgloo)
library.add(faMoneyBill)

class App extends Component {
  constructor() {
    super()
    this.state = {
      listOfTournaments: [],
      loading: true
    }
  }

  componentDidMount() {
    axios.get('http://localhost:50434/api/tournaments/')
      .then(response =>
        this.setState({ listOfTournaments: response.data, loading: false })
      ).catch();

  }

  render() {

    return (
      <div className=''>
        < Header />
        <div className="container-fluid bg-cl-silver">
          <div className="container">
            {this.state.listOfTournaments.map((item, index) => (
              < TourneyCard key={index} item={item} />
            ))}
          </div>
        </div>
      </div>
    )
  }
}

export default App