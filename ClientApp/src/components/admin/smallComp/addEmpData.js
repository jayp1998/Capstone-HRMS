import React, {Component} from 'react';

export default class AddEmpData extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div className="card shadow mb-4">
                <div className="card-header py-3">
                    <h6 className="m-0 font-weight-bold text-primary">ADD EMPLOYEE</h6>
                </div>
                <form className="col-md-6 mt-4">
                    <div className="form-group row">
                        <div className="col-sm-6 mb-3 mb-sm-0">
                            <input type="text" className="form-control form-control-user"
                                   id="exampleFirstName"
                                   placeholder="First Name"/>
                        </div>
                        <div className="col-sm-6">
                            <input type="text" className="form-control form-control-user"
                                   id="exampleLastName"
                                   placeholder="Last Name"/>
                        </div>
                    </div>
                    <div className="form-group">
                        <input type="email" className="form-control form-control-user"
                               id="exampleInputEmail"
                               placeholder="Email Address"/>
                    </div>
                    <div className="form-group row">
                        <div className="col-sm-6 mb-3 mb-sm-0">
                            <input type="text" className="form-control form-control-user"
                                   id="exampleFirstName"
                                   placeholder="Phone No"/>
                        </div>
                    </div>
                    <div className="form-group row">
                        <div className="col-sm-6 mb-3 mb-sm-0">
                            <h5><span className="label label-primary">Date of Birth</span></h5>
                            <input type="Date" className="form-control form-control-user"
                                   id="exampleFirstName"
                                   placeholder="DOB"/>
                        </div>
                    </div>
                    <div className="form-group row">
                        <div className="col-sm-6 mb-3 mb-sm-0">
                            <h5><span className="label label-primary">Date of Joining</span></h5>
                            <input type="Date" className="form-control form-control-user"
                                   id="exampleFirstName"
                                   placeholder="DOJ"/>
                        </div>
                    </div>
                    <div className="form-group row">
                        <div className="col-sm-6 mb-3 mb-sm-0">
                            <input type="text" className="form-control form-control-user"
                                   id="exampleFirstName"
                                   placeholder="SIN"/>
                        </div>
                    </div>
                    <div className="form-group row">
                        <div className="col-sm-6 mb-3 mb-sm-0">
                            <input type="text" className="form-control form-control-user"
                                   id="exampleFirstName"
                                   placeholder="DEPT"/>
                        </div>
                        <div className="col-sm-6 mb-3 mb-sm-0">
                            <input type="text" className="form-control form-control-user"
                                   id="exampleFirstName"
                                   placeholder="Designation"/>
                        </div>
                    </div>
                    <button className="btn btn-primary btn-user btn-block col-md-3">ADD EMPLOYEE</button>
                </form>
            </div>

        );
    }
}
