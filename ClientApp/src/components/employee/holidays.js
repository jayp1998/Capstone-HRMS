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
                        <div className="container">
                            <h2>2021 Holidays</h2>
                            <p>The common holidays:</p>
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
                <Footer/>
            </div>

        );
    }
}
