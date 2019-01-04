import React from 'react'

const TourneyTitle = (props) => {
    return (
        <div>
            <i className="swg swg-darthvader"></i>
            <div style={{ fontSize: '1.25em', fontWeight: 'bold' }}>Name: {props.name}</div>
        </div>

    );
};

export default TourneyTitle;