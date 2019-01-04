import React from 'react'
import TourneyTitle from './TourneyTitle'
import './TourneyCard.css';

const TourneyCard = (props) => {
    return (
        <div className="bg-cl-near-white bg-ourney-card-border mb-3 p-2">
        < TourneyTitle {...props.item} />
            <p>Detale</p>
        </div>

    );
};

export default TourneyCard