import React from 'react'
import { Badge } from 'reactstrap'

const TourneyTitle = (props) => {
    return (
        <div>
            <i className="swg swg-darthvader"></i>
            <div style={{ fontSize: '1.25em', fontWeight: 'bold' }}>Name: {props.tournamentName}<Badge color="secondary">New</Badge></div>
        </div>

    );
};

export default TourneyTitle;