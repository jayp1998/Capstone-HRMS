import React, {Component} from 'react';

export default class ScheduleData extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div className="card shadow mb-4">
                <div className="card-header py-3">
                    <h6 className="m-0 font-weight-bold text-primary">Plan a Schedule</h6>
                </div>
                <div className="card-body">
                    <div className="col-md-12">
                        <form className="user">
                            <div className="form-group row  justify-content-center">
                                <div className="col-sm-6 mb-3 mb-sm-0">
                                    <input type="text" className="form-control form-control-user"
                                           id="User ID"
                                           placeholder="User ID"/>
                                </div>
                            </div>
                            <div className="form-group row  justify-content-center">
                                <div className="col-sm-6 mb-3 mb-sm-0">
                                    <label htmlFor="timeslot">Choose a slot</label>
                                    <select className="form-select" id="slot" name="slot">
                                        <option value="9-12">9-12</option>
                                        <option value="12-3">12-3</option>
                                        <option value="3-6">3-6</option>
                                        <option value="6-9">6-9</option>
                                    </select>
                                </div>
                            </div>
                            <div className="form-group row justify-content-center">
                                <div className="col-sm-6 mb-3 mb-sm-0">
                                    <label htmlFor="1833993761">Date</label>
                                    <div className="form-group">
                                        <input type="date" id="date" placeholder="Select Date"
                                               className="form-control" required/>
                                    </div>
                                </div>
                            </div>
                            <div className="form-group row  justify-content-center">
                                <div className="col-sm-6 mb-3 mb-sm-0">
                                    <input type="text" className="form-control form-control-user"
                                           id="User ID"
                                           placeholder="Duties"/>
                                </div>
                            </div>
                            <div className="form-group row  justify-content-center">
                                <div className="col-sm-6 mb-3 mb-sm-0">
                                    <button className="btn btn-info btn-user btn-block col-md-3">Add Schedule</button>
                                </div>
                            </div>

                        </form>
                    </div>
                </div>
            </div>
        );
    }
}
