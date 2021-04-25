import React, {Component} from 'react';
import NAV from './nav';
import TOPNAV from './topnav';

export class AddPayroll extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div id="wrapper">
                <NAV/>
                <div id="content-wrapper" className="d-flex flex-column">
                    <TOPNAV/>
                    <div className="col-xl-5 col-lg-5">
                        <div className="card shadow mb-4">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="m-0 font-weight-bold text-primary">Add New Holiday</h6>
                            </div>
                            <div className="card-body">
                                <form className="user">
                                    <div className="form-group row">
                                        <div className="form-group">
                                            <input type="text" className="form-control form-control-user"
                                                   id="exampleLastName"
                                                   placeholder="EMP ID"/>
                                        </div>
                                    </div>
                                    <div className="form-group row">
                                        <div className="form-group">
                                            <input type="text" className="form-control form-control-user"
                                                   id="exampleLastName"
                                                   placeholder="Basic Salary"/>
                                        </div>
                                    </div>
                                    <button className="btn btn-success btn-user btn-block col-md-3">Add To Payroll</button>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
