import React, {Component} from 'react';

export default class DeleteEmpData extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div className="card shadow mb-4">
                <div className="card-header py-3">
                    <h6 className="m-0 font-weight-bold text-primary">DELETE EMPLOYEE</h6>
                </div>
                <form className="col-md-12">
                    <br/>
                    <br/>
                    <div className="input-group col-md-4">
                        <input type="text" className="form-control bg-light border-2 large" placeholder="Search for..."
                               aria-label="Search" aria-describedby="basic-addon2" />
                        <div className="input-group-append">
                            <button className="btn btn-info" type="button">
                                <i className="fas fa-search fa-sm"/>
                            </button>
                        </div>
                    </div>
                    <br/>
                    <br/>
                    <div className="card-header py-3">
                        <h6 className="m-0 font-weight-bold text-primary">RESULTS</h6>
                    </div>
                    <div className="card-body">
                        <div className="table-responsive">
                            <table className="table table-bordered" id="dataTable" width="100%" cellSpacing="0">
                                <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>NAME</th>
                                    <th>DEPT</th>
                                    <th>Age</th>
                                </tr>
                                </thead>
                                <tbody>
                                <tr>
                                    <td>001</td>
                                    <td>Jay</td>
                                    <td>IT</td>
                                    <td>22</td>
                                </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <button className="btn btn-danger btn-user btn-block col-md-3">DELETE EMPLOYEE</button>
                </form>
            </div>
        );
    }
}






















