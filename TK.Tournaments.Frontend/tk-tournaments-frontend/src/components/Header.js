import React from 'react';
import './Header.css'

const Header = (props) => {
    return (
        <div className="container-fluid cl=near-white p-0">
            <div className="container p-1">
                <h1 className="cl-red">Tourney Keeper</h1>
            </div>
            <div className="box bg-cl-red">
                <div className="container cl-red">
                    <div className="bg-cl-near-white d-inline-flex ">Just Joust</div>
                </div>
            </div>
        </div>
    );
};
export default Header;