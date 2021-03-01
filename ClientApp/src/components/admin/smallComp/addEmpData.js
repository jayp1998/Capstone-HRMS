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
                        <form className="user">
                            <div className="form-group row">
                                <div className="col-sm-6 mb-3 mb-sm-0">
                                    <input type="text" className="form-control form-control-user" id="exampleFirstName"
                                        placeholder="First Name"/>
                                    </div>
                                    <div className="col-sm-6">
                                        <input type="text" class="form-control form-control-user" id="exampleLastName"
                                            placeholder="Last Name"/>
                                    </div>
                                    </div>
                            </form>
                    </div>
                   </div>
            </div>

        );
    }
}
