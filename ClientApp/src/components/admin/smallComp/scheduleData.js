import React, {Component} from 'react';

export default class ScheduleData extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div className="card shadow mb-4">
                <div className="card-header py-3">
                    <h6 className="m-0 font-weight-bold text-primary">Plan a Schedule</h6>
                </div>
                <div className="card-body">
                    <div className="table-responsive">
                       <table className="table table-bordered" id="dataTable" width="100%" cellSpacing="0">
                           <thead>
                            <tr>
                                <th>Time</th>
                                <th>Monday</th>
                                <th>Tuesday</th>
                                <th>Wednesday</th>
                                <th>Thursday</th>
                                <th>Friday</th>
                                <th>Saturday</th>
                            </tr>
                            </thead>
                            <tbody>

                            <tr>
                                <td>9-12</td>
                                <td>USER1</td>
                                <td>USER1</td>
                                <td>USER1</td>
                                <td>USER1</td>
                                <td>USER1</td>
                                <td>USER1</td>
                            </tr>
                            </tbody>

                        </table></div>
                </div>
            </div>
        );
    }
}
