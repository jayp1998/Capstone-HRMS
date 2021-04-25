import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';

export class LeaveManagement extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div id="wrapper">
                <NAV/>
                <div id="content-wrapper" className="d-flex flex-column">
                    <TOPNAV/>
                    <div className="card shadow mb-4">
                        <div className="card-header py-3">
                            <h6 className="m-0 font-weight-bold text-primary">ALL Leaves</h6>
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" cellSpacing="0">
                                    <thead>
                                    <tr>
                                        <th>ID</th>
                                        <th>NAME</th>
                                        <th>Reason</th>
                                        <th>No of Days</th>
                                    </tr>
                                    </thead>
                                    <tbody>
                                    <tr>
                                        <td>001</td>
                                        <td>Jay</td>
                                        <td>Ill</td>
                                        <td>3</td>

                                    </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
