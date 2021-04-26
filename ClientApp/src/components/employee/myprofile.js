import React, {Component} from 'react';
import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";
import {Link} from "react-router-dom";

export class Myprofile extends Component {
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
                                <h6 className="m-0 font-weight-bold text-primary">My Profile</h6>
                                <Link to="/editprofile">
                                    <button className="btn btn-primary">Edit Profile</button>
                                </Link>
                            </div>
                            <div className="card-body">
                                <div className="row">
                                    <div className="col-md-3">
                                        <img src="https://images.unsplash.com/photo-1509599973441-61e5ec2cac91?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80"
                                             alt="Profile-pic" className="img-thumbnail"/>
                                    </div>
                                    <div className="col-md-3">
                                        <h6>Employee Name:- Jay</h6>
                                        <h6>Employee Title:- xyz</h6>
                                        <h6>Employee No:- EMP001</h6>
                                    </div>
                                    <div className="col-md-3">
                                        <h6>Phone:- xyz</h6>
                                        <h6>Email:- xyz</h6>
                                        <h6>Birth Date:- xyz</h6>
                                        <h6>Address:- xyz</h6>
                                        <h6>Gender:- xyz</h6>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div className="row">
                    <div className="col-md-4">
                        <div className="card shadow mb-4">
                            <div
                                className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                <h6 className="m-0 font-weight-bold text-primary">Skills</h6>
                            </div>
                            <div className="card-body">
                                <h6>Skill - 1</h6>
                            </div>
                        </div>
                    </div>
                        <div className="col-md-4">
                            <div className="card shadow mb-4">
                                <div
                                    className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                    <h6 className="m-0 font-weight-bold text-primary">Education</h6>
                                </div>
                                <div className="card-body">
                                    <ul className="list-group">
                                        <li className="list-group-item">1</li>
                                        <li className="list-group-item">2</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div className="col-md-4">
                            <div className="card shadow mb-4">
                                <div
                                    className="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                                    <h6 className="m-0 font-weight-bold text-primary">Experience</h6>
                                </div>
                                <div className="card-body">
                                    <ul className="list-group">
                                        <li className="list-group-item">1</li>
                                        <li className="list-group-item">2</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <Footer/>
            </div>

        );
    }
}
