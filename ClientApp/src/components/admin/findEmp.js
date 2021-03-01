import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';
import SearchData from './smallComp/searchEmpData';

export class findEmp extends Component {
    // eslint-disable-next-line no-useless-constructor
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div id="wrapper">
                <NAV/>
                <div id="content-wrapper" className="d-flex flex-column">
                    <TOPNAV/>
                    <SearchData/>
                </div>
            </div>
        );
    }
}
