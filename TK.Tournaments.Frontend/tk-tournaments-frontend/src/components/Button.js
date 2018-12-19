import React from 'react';
import { Button } from 'reactstrap';

const Button = (onClick) => {
    return (
        <div>
            <button onClick={this.props.onclick}>
                Get tourney!
            </button>
        </div>
    );
}

export default Button;