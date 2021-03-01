import React, {Component} from 'react';
import './css/main.css';
import './css/fontawesome.css';

import NAV from './nav';
import TOPNAV from './topnav';
import TotalEmp from './smallComp/totalEmp';

export class adminIndex extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div id="wrapper">
                <NAV/>
                <div id="content-wrapper" className="d-flex flex-column">
                    <TOPNAV/>
                    <div className="container-fluid">
                        <div className="row">
                            <TotalEmp/>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
