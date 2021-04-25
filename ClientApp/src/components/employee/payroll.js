import React, {Component} from 'react';
import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";
import Pdf from "react-to-pdf";
export class Payroll extends Component {
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
                    <p className="h3 d-flex justify-content-center">Payroll History</p>
                    <div className="col-xl-12 col-lg-5 d-flex justify-content-center">
                        <div className="card shadow col-md-8" ref={ref}>
                            <div
                                className="card-header d-flex flex-row align-items-center justify-content-between">
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
                    <div className="d-flex p-2 justify-content-center">
                        <Pdf targetRef={ref} filename="Invoice.pdf">
                            {({ toPdf }) => <button className="btn btn-info btn-icon-split" onClick={toPdf}>Generate Pdf</button>}
                        </Pdf>
                    </div>
                </div>
                <Footer/>
            </div>

        );
    }
}
