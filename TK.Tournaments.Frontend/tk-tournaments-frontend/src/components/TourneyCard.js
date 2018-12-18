import React from 'react'
import TourneyTitle from './TourneyTitle'

const TourneyCard = (props) => {
    return (
        <div>
        < TourneyTitle {...props} />
            <div style={{ display: 'inline' }}>
                
                <div>Id: <span>{props.id}</span></div>
            </div>
            <div>
                <div style={{ width: '40%', textAlign: 'center' }}> {props.description} </div>
                {props.ifTopCut && <h5>Top Cut</h5>}
            </div>
        </div>

    );
};

export default TourneyCard