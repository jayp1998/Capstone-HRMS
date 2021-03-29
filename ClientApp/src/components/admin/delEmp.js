import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';
//import DeleteEmployee from "./smallComp/deleteEmployee";


export class delEmp extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div id="wrapper">
                <NAV/>
                <div id="content-wrapper" className="d-flex flex-column">
                    <TOPNAV/>
                </div>
            </div>
        );
    }
}
