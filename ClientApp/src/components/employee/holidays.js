import React, {Component} from 'react';
import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";
export class Holidays extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div className="admin">
                <Header/>
                <EMPNAV/>
                <div className="admin__main">
                    <div className="col-xl-8 col-lg-5">
                        <div className="card shadow mb-4">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="m-0 font-weight-bold text-primary">Holiday List</h6>
                            </div>
                            <div className="card-body">
                                <table className="table table-condensed">
                                    <thead>
                                    <tr>
                                        <th>Date</th>
                                        <th>Holiday</th>
                                    </tr>
                                    </thead>
                                    <tbody>
                                    <tr>
                                        <td> January 1 2021</td>
                                        <td>New Year's Day</td>
                                    </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <Footer/>
            </div>

        );
    }
}


