import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';
import AddEmpData from './smallComp/addEmpData';

export class addEmp extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div id="wrapper">
                <NAV/>
                <div id="content-wrapper" class="d-flex flex-column">
                    <TOPNAV/>
                    <AddEmpData/>
                </div>
            </div>

        );
    }
}
