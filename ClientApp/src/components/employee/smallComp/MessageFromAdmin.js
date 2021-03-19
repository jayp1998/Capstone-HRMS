import React, {Component} from 'react';

export default class MessageFromAdmin extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div className="col-xl-5 col-lg-5">
                <div className="card shadow mb-4">
                    <div
                        className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                        <h6 className="m-0 font-weight-bold text-primary">Message From Admin</h6>
                    </div>
                    <div className="card-body">
                        <div className="form-group">
                            <p className="h3">
                                Hello There ! This is the component where broadcasted messages will be shown to all the employees
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
