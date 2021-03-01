﻿import React, {Component} from 'react';
import profile from './img/profile.png';

export default class TOPNAV extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <nav className="navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow">
                <button id="sidebarToggleTop" className="btn btn-link d-md-none rounded-circle mr-3">
                    <i className="fa fa-bars"/>
                </button>

                <ul className="navbar-nav ml-auto">


                    <div className="topbar-divider d-none d-sm-block"/>

                    <li className="nav-item dropdown no-arrow">
                        {/* eslint-disable-next-line jsx-a11y/anchor-is-valid */}
                        <a className="nav-link dropdown-toggle" href="#" id="userDropdown" role="button"
                                data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            <span className="mr-2 d-none d-lg-inline text-gray-600 small">Admin</span>
                            <img className="img-profile rounded-circle" src={profile}  alt="profile"/>
                            </a>

                        <div className="dropdown-menu dropdown-menu-right shadow animated--grow-in"
                                    aria-labelledby="userDropdown">
                            {/* eslint-disable-next-line jsx-a11y/anchor-is-valid */}
                            <a className="dropdown-item" href="#">
                                <i className="fas fa-user fa-sm fa-fw mr-2 text-gray-400"/>
                                    Profile
                                </a>
                            <div className="dropdown-divider"/>
                            {/* eslint-disable-next-line jsx-a11y/anchor-is-valid */}
                            <a className="dropdown-item" href="#" data-toggle="modal" data-target="#logoutModal">
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




































