import React, {Component} from 'react';

export default class AllEmpData extends Component {
    constructor(props) {
        super(props);

    }
    render() {
        return (
            <div className="card shadow mb-4">
                <div className="card-header py-3">
                    <h6 className="m-0 font-weight-bold text-primary">ALL EMPLOYEE</h6>
                </div>
                <form className="col-md-12">
                    <br/>
                    <br/>
                    <div className="input-group col-md-4">
                        <input type="text" className="form-control bg-light border-2 large" placeholder="Search for..."
                               aria-label="Search" aria-describedby="basic-addon2" />
                        <div className="input-group-append">
                            <button className="btn btn-primary" type="button">
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
                                    <th>DESIGNATION</th>
                                    <th>Update</th>
                                    <th>Delete</th>
                                </tr>
                                </thead>
                                <tbody>
                                <tr>
                                    <td>
                                        <ul className="list-group">
                                            <li className="list-group-item">
                                                <input type="text"/>
                                            </li>
                                        </ul>
                                    </td>
                                    <td>
                                        <li className="list-group-item">
                                            <input type="text"/>
                                        </li>
                                    </td>
                                    <td>
                                        <li className="list-group-item">
                                            <input type="text"/>
                                        </li>
                                    </td>
                                    <td>
                                        <button className="btn btn-primary">UPDATE</button>
                                    </td>
                                    <td>
                                        <button className="btn btn-danger">DELETE</button>
                                    </td>
                                </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </form>
            </div>
        );
    }
}






















