import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';
import ScheduleData from "./smallComp/scheduleData";

export class schedule extends Component {
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
                    <ScheduleData/>
                </div>
            </div>
        );
    }
}









