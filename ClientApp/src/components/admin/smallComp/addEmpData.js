import React, {Component} from 'react';

export default class AddEmpData extends Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div className="card o-hidden border-0 shadow-lg my-5">
                <div className="card-body p-0">
                    <div className="row">
                        <div className="col-lg-7">
                            <div className="p-5">
                                <div className="text-center">
                                    <h1 className="h4 text-gray-900 mb-4">Add An Employee</h1>
                                </div>
                                <form className="user">
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
                                <button className="btn btn-primary btn-user btn-block col-md-3">ADD EMPLOYEE</button>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        );
    }
}
