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
                                    <th>Day</th>
                                    <th>Days to go</th>
                                </tr>
                                </thead>
                                <tbody>
                                <tr>
                                    <td> January 1 2021</td>
                                    <td>New Year's Day</td>
                                    <td>Friday</td>
                                    <td> -</td>
                                </tr>
                                <tr>
                                    <td>January 18 2021</td>
                                    <td>Martin Luther King Day</td>
                                    <td> Monday</td>
                                    <td> -</td>
                                </tr>
                                <tr>
                                    <td>January 24 2021</td>
                                    <td>Belly Laugh Day</td>
                                    <td> Sunday</td>
                                    <td> -</td>
                                </tr>
                                <tr>
                                    <td>February 2 2021</td>
                                    <td>Groundhog Day</td>
                                    <td> Tuesday</td>
                                    <td> -</td>
                                </tr>

                                <tr>
                                    <td>March 14 2021</td>
                                    <td>Daylight Saving
                                        (Start)
                                    </td>
                                    <td> Sunday</td>
                                    <td> -</td>
                                </tr>

                                <tr>
                                    <td>March 17 2021</td>
                                    <td>St. Patrick's Day</td>
                                    <td> Wednesday</td>
                                    <td> -</td>
                                </tr>
                                <tr>
                                    <td>April 1 2021</td>
                                    <td>April Fool's Day</td>
                                    <td> Thursday</td>
                                    <td> 14</td>
                                </tr>

                                <tr>
                                    <td>April 2 2021</td>
                                    <td>Good Friday</td>
                                    <td> Friday</td>
                                    <td> 15</td>
                                </tr>


                                <tr>
                                    <td>April 4 2021</td>
                                    <td>Easter</td>
                                    <td>Sunday</td>
                                    <td> 17</td>
                                </tr>
                                <tr>
                                    <td>April 5 2021</td>
                                    <td>Easter Monday</td>
                                    <td>monday</td>
                                    <td> 18</td>
                                </tr>

                                <tr>
                                    <td>April 22 2021</td>
                                    <td>Earth Day</td>
                                    <td>Thursday</td>
                                    <td> 35</td>
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
