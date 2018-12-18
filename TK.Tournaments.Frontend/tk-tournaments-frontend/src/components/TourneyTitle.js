import React from 'react'

const TourneyTitle = (props) => {
    return (
        <div>
            <i class="swg swg-darthvader"></i>
            <div style={{ fontSize: '1.25em', fontWeight: 'bold' }}>Name: {props.tournamentName}</div>
        </div>

    );
};

export default TourneyTitle;