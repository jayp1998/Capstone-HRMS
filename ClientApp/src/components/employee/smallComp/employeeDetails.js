import React, {Component} from 'react';

export default class EmployeeDetails extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div className="col-xl-12 col-lg-5">
                <div className="card shadow mb-4">
                    <div
                        className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                        <h6 className="m-0 font-weight-bold text-primary">Employee Details</h6>
                    </div>
                    <div className="card-body">
                        <div className="row">
                            <div className="col-md-6">
                                <p>Employee Name:- Jay</p>
                            </div>
                            <div className="col-md-6">
                                <p>Employee No:- EMP001</p>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-md-6">
                                <p>Employee Dept:- IT</p>
                            </div>
                            <div className="col-md-6">
                                <p>Employee Designation:- Developer</p>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        );
    }
}
