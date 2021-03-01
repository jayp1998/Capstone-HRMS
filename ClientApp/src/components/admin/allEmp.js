import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';
import AllEmpData from './smallComp/allEmpData';


export class allEmp extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div id="wrapper">
                <NAV/>
                <div id="content-wrapper" className="d-flex flex-column">
                    <TOPNAV/>
                    <AllEmpData/>
                </div>
            </div>
        );
    }
}
