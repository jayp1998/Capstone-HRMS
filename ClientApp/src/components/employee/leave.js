import React, {Component} from 'react';
import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";
export class Leave extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div className="admin">
                <Header/>
                <EMPNAV/>
                <div className="admin__main">
                    <div className="col-xl-8 col-lg-5">
                        <div className="card shadow mb-4">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="m-0 font-weight-bold text-primary">Leave Management</h6>
                            </div>
                            <div className="card-body">
                                <form>
                                    <div className="form-group">
                                        <label htmlFor="name">Name*</label>
                                        <input type="text" className="form-control" id="name" placeholder="Your name"
                                               required/>
                                    </div>

                                    <div className="form-group">
                                        <label htmlFor="email">email*</label>
                                        <input type="text" className="form-control" id="email" placeholder="Your email"
                                               required />
                                    </div>

                                    <div className="form-group">
                                        <label htmlFor="telephone">Telephone*</label>
                                        <input type="text" className="form-control" id="telephone"
                                               placeholder="Your telephone number" required minLength="7" maxLength="12"/>
                                    </div>
                                    <div className="form-group">
                                        <label htmlFor="m_name">Managere's Name*</label>
                                        <input type="text" className="form-control" id="m_name"
                                               placeholder="managere's name" required/>
                                    </div>


                                    <div className="form-group">
                                        <select className="custom-select" required>
                                            <option value="" selected>Select a leave reason*</option>
                                            <option value="1">vacation</option>
                                            <option value="2">sick leave</option>
                                            <option value="3">maternity/paternity</option>
                                            <option value="4">time off without pay</option>
                                            <option value="5">other</option>
                                        </select>
                                    </div>

                                    <div className="form-group">
                                        <label htmlFor="1833993761">Start Date</label>
                                        <div className="form-group">
                                            <input type="date" id="1989254035_date" placeholder="Date Start"
                                                   className="form-control" required/>
                                        </div>
                                    </div>

                                    <div className="form-group">
                                        <label htmlFor="861643251">End Date</label>
                                        <div className="form-group">
                                            <input type="date" id="1403025287_date" placeholder="Date Ends"
                                                   className="form-control" required/>
                                        </div>
                                    </div>
                                    <div className="form-group">
                                        <label htmlFor="">Time-off comments</label>
                                        <div className="form-group">
                                        <textarea id="" name="" className="form-control"
                                                  required></textarea>
                                        </div>
                                    </div>

                                    <button type="submit" className="btn btn-info">Submit</button>
                                </form>

                            </div>
                        </div>
                    </div>
                </div>
                <Footer/>
            </div>

        );
    }
}


