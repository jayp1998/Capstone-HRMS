import React, {Component} from 'react';

export default class AddHoliday extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
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
                                    <label htmlFor="1833993761">Date</label>
                                    <div className="form-group">
                                        <input type="date" id="date" placeholder="Select Date"
                                               className="form-control" required/>
                                    </div>
                                </div>
                            </div>
                            <div className="form-group row">
                                <div className="form-group">
                                    <input type="text" className="form-control form-control-user"
                                           id="exampleLastName"
                                           placeholder="Which Holiday ?"/>
                                </div>
                            </div>
                            <button className="btn btn-success btn-user btn-block col-md-3">Add Holiday</button>
                        </form>
                    </div>
                </div>
            </div>
        );
    }
}


