import React, {Component} from 'react';
import profile from "../admin/img/profile.png";
import {Link} from "react-router-dom";
export default class Header extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
                <nav className="navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow">

                    <ul className="navbar-nav ml-auto">
                        <div className="topbar-divider d-none d-sm-block"/>
                        <li className="nav-item dropdown no-arrow">
                            {/* eslint-disable-next-line jsx-a11y/anchor-is-valid */}
                            <a className="nav-link dropdown-toggle" href="#" id="userDropdown" role="button"
                               data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                <span className="mr-2 d-none d-lg-inline text-gray-600 small">Employee</span>
                                <img className="img-profile rounded-circle" src={profile}  alt="profile"/>
                            </a>
                            <div className="dropdown-menu dropdown-menu-right shadow animated--grow-in"
                                 aria-labelledby="userDropdown">
                                {/* eslint-disable-next-line jsx-a11y/anchor-is-valid */}



                                    <Link className="dropdown-item"  to="/myprofile">
                                        <i className="fas fa-user fa-sm fa-fw mr-2 text-gray-400"/>My Profile</Link>

                                <div className="dropdown-divider"/>
                                {/* eslint-disable-next-line jsx-a11y/anchor-is-valid */}
                                <a className="dropdown-item" href="#" >
                                    <i className="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"/>
                                    Logout
                                </a>
                            </div>
                        </li>

                    </ul>
                </nav>

        );
    }
}
