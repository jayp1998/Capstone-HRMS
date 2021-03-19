import React, {Component} from 'react';
import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";
export class Payroll extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div className="admin">
                <Header/>
                <EMPNAV/>
                <div className="admin__main">
                    <p className="h3 d-flex justify-content-center">Payroll History</p>
                    <div className="col-xl-12 col-lg-5 d-flex justify-content-center">
                        <div className="card shadow col-md-8">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="col-md-8 font-weight-bold text-primary">This Month Pay</h6>
                            </div>
                            <div className="card-body">
                                <div className="row h3">
                                    <div className="col-md-8">
                                        <p>Amount:- $880</p>
                                    </div>
                                    <div className="col-md-8">
                                        <p>Gross Pay :- $1289</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br/>
                    <div className="col-xl-12 col-lg-5 d-flex justify-content-center">
                        <div className="card shadow col-md-8">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="col-md-8 font-weight-bold text-primary">Last Month Pay</h6>
                            </div>
                            <div className="card-body">
                                <div className="row h3">
                                    <div className="col-md-8">
                                        <p>Amount:- $770</p>
                                    </div>
                                    <div className="col-md-8">
                                        <p>Gross Pay :- $900</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <Footer/>
            </div>

        );
    }
}
