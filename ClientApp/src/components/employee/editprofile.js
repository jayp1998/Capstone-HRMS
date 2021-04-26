import React, {Component} from 'react';
import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";

export class Editprofile extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        const ref = React.createRef();
        return (
            <div className="admin">
                <Header/>
                <EMPNAV/>
                <div className="admin__main">
                    <div className="col-xl-12 col-lg-5">
                        <div className="card shadow mb-4">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="m-0 font-weight-bold text-primary">Edit Profile</h6>
                            </div>
                            <div className="card-body">
                                <form>
                                <div className="row">
                                    <div className="col-md-3">
                                        <img src="https://images.unsplash.com/photo-1509599973441-61e5ec2cac91?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80"
                                             alt="Profile-pic" className="img-thumbnail"/>
                                        <button className="btn btn-primary">Upload</button>
                                    </div>
                                    <div className="col-md-3">
                                        <div className="form-group">
                                            <input type="text" className="form-control" id="name" placeholder="Your name" required/>
                                        </div>
                                        <div className="form-group">
                                            <label htmlFor="1833993761">Date of Birth</label>
                                            <div className="form-group">
                                                <input type="date" id="bday" placeholder="DOB"
                                                       className="form-control" required/>
                                            </div>
                                        </div>
                                    </div>
                                    <div className="col-md-3">
                                        <div className="form-group">
                                            <input type="text" className="form-control" id="name" placeholder="Last Name" required/>
                                        </div>
                                        <div className="form-group">
                                            <label htmlFor="gender">Gender</label>
                                            <select className="form-control" id="gender">
                                                <option>Male</option>
                                                <option>Female</option>
                                            </select>
                                        </div>
                                    </div>
                                </div></form>

                            </div>
                        </div>
                    </div>
                        <div className="col-xl-12 col-lg-5">
                            <div className="card shadow mb-4">
                                <div
                                    className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                    <h6 className="m-0 font-weight-bold text-primary">Contact Info</h6>
                                </div>
                                <div className="card-body">
                                    <form>
                                        <div className="row">
                                            <div className="col-md-12">
                                                <div className="form-group">
                                                    <p>Address</p>
                                                    <input type="text" className="form-control" id="name" placeholder="Address"
                                                           required/>
                                            </div>
                                            </div>
                                        </div>
                                        <div className="row">
                                            <div className="col-md-6">
                                                <div className="form-group">
                                                    <label htmlFor="1833993761">State</label>
                                                    <input type="text" className="form-control" id="name" placeholder="State" required/>
                                                </div>
                                                <div className="form-group">
                                                    <label htmlFor="1833993761">Zipcode</label>
                                                    <div className="form-group">
                                                        <input type="text" id="bday" placeholder="Zipcode" className="form-control" required/>
                                                    </div>
                                                </div>
                                            </div>
                                            <div className="col-md-6">
                                                <div className="form-group">
                                                    <label htmlFor="1833993761">Country</label>
                                                    <input type="text" className="form-control" id="Country" placeholder="Country" required/>
                                                </div>
                                                <div className="form-group">
                                                    <label htmlFor="1833993761">Phone No</label>
                                                    <div className="form-group">
                                                        <input type="text" id="bday" placeholder="Phone no" className="form-control" required/>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </form>
                                </div>
                            </div>
                    </div>

                    <div className="col-xl-12 col-lg-5">
                        <div className="card shadow mb-4">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="m-0 font-weight-bold text-primary">Education Info</h6>
                            </div>
                            <div className="card-body">
                                <form>
                                    <div className="row">
                                        <div className="col-md-6">
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Institution</label>
                                                <input type="text" className="form-control" id="name" placeholder="Institution" required/>
                                            </div>
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Start Date</label>
                                                <div className="form-group">
                                                    <input type="date" id="bday" placeholder="DOB"
                                                           className="form-control" required/>
                                                </div>
                                            </div>
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Degree</label>
                                                <div className="form-group">
                                                    <input type="text" id="bday" placeholder="Degree" className="form-control" required/>
                                                </div>
                                            </div>
                                        </div>
                                        <div className="col-md-6">
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Major</label>
                                                <input type="text" className="form-control" id="Country" placeholder="Major" required/>
                                            </div>
                                            <div className="form-group">
                                                <label htmlFor="1833993761">End Date</label>
                                                <div className="form-group">
                                                    <input type="date" id="bday" placeholder="DOB"
                                                           className="form-control" required/>
                                                </div>
                                            </div>
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Grade</label>
                                                <div className="form-group">
                                                    <input type="text" id="bday" placeholder="Grade" className="form-control" required/>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                <button className="btn btn-primary">Add More</button>
                                </form>
                            </div>
                        </div>
                    </div>

                    <div className="col-xl-12 col-lg-5">
                        <div className="card shadow mb-4">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="m-0 font-weight-bold text-primary">Experience</h6>
                            </div>
                            <div className="card-body">
                                <form>
                                    <div className="row">
                                        <div className="col-md-6">
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Company Name</label>
                                                <input type="text" className="form-control" id="name" placeholder="Company Name" required/>
                                            </div>
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Start Date</label>
                                                <div className="form-group">
                                                    <input type="date" id="bday" placeholder="DOB"
                                                           className="form-control" required/>
                                                </div>
                                            </div>
                                            <div className="form-group">
                                                <label htmlFor="1833993761">ROLE</label>
                                                <div className="form-group">
                                                    <input type="text" id="bday" placeholder="ROLE" className="form-control" required/>
                                                </div>
                                            </div>
                                        </div>
                                        <div className="col-md-6">
                                            <div className="form-group">
                                                <label htmlFor="1833993761">Location</label>
                                                <input type="text" className="form-control" id="Country" placeholder="Location" required/>
                                            </div>
                                            <div className="form-group">
                                                <label htmlFor="1833993761">End Date</label>
                                                <div className="form-group">
                                                    <input type="date" id="bday" placeholder="DOB"
                                                           className="form-control" required/>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <button className="btn btn-primary">Add More</button>
                                </form>
                            </div>
                        </div>
                    </div>
                    <div className="text-center mb-5">
                        <button type="button" className="btn btn-primary">Update Profile</button>
                    </div>

               </div>
                <Footer/>
            </div>

        );
    }
}
