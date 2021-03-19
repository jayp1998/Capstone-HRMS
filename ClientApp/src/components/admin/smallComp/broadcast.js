import React, {Component} from 'react';

export default class Broadcast extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div className="col-xl-5 col-lg-5">
                <div className="card shadow mb-4">
                    <div
                        className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                        <h6 className="m-0 font-weight-bold text-primary">Broadcast Message</h6>
                    </div>
                    <div className="card-body">
                        <div className="form-group">
                            <label htmlFor="exampleFormControlTextarea1">Send Message to all Employees</label>
                            <textarea className="form-control"  rows="5"></textarea>
                        </div>
                        <button className="btn btn-success btn-icon-split">SEND</button>
                    </div>
                </div>
            </div>
        );
    }
}


