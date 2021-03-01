import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';


export class delEmp extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div id="wrapper">
                <NAV></NAV>
                <div id="content-wrapper" class="d-flex flex-column">
                    <TOPNAV></TOPNAV>
                </div>
            </div>
        );
    }
}
