import React, {Component} from 'react';
import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";
export class MainSchedule extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        const ref = React.createRef();
        return (
            <div className="admin">
                <Header/>
                <EMPNAV/>
                <div className="admin__main">
                    <div className="col-xl-12 col-lg-5 d-flex justify-content-center">
                        <div className="card shadow col-md-8">
                            <div
                                className="card-header d-flex flex-row align-items-center justify-content-between">
                                <h6 className="col-md-8 font-weight-bold text-primary">My Schedule</h6>
                            </div>
                            <div className="card-body">
                                <h4>Date:-  </h4>
                                <h4>Slot:-  </h4>
                                <h4>Duties:-  </h4>
                            </div>
                        </div><br/>
                    </div>
                </div>
                <Footer/>
            </div>

        );
    }
}
