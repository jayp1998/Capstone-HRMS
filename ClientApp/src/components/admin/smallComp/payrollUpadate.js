import React, {Component} from 'react';
import {Link} from "react-router-dom";

export default class PayrollUpadate extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div className="col-xl-3 col-md-6 mb-4">
                <div className="card border-left-success shadow h-100 py-2">
                    <div className="card-body">
                        <div className="row no-gutters align-items-center">
                            <div className="col mr-2">
                                <div className="text-xs font-weight-bold text-primary text-uppercase mb-1">
                                    Update Payroll</div>
                                <div className="h5 mb-0 font-weight-bold text-gray-800"> <Link to='/updatepayroll'><button className="btn btn-success btn-icon-split">Go to Payroll Page</button></Link></div>
                            </div>
                            <div className="col-auto">
                                <i className="fas fa-money-bill fa-2x text-gray-300"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
