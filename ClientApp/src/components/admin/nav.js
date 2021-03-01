import React, {Component} from 'react';
import {Link} from 'react-router-dom';

export default class NAV extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <nav>
                <ul className="navbar-nav  bg-gradient-primary sidebar sidebar-dark accordion" id="accordionSidebar">
                    <li className="nav-item active">                   
                        <div className="nav-item" >
                            <Link className="nav-link" to="/adminIndex">
                            <i className="fas fa-fw fa-tachometer-alt"/>
                                <span>Dashboard</span>
                            </Link>
                        </div>
                    </li>

                    <hr className="sidebar-divider" /> {/* Dashboard Ends */}

            <div className="sidebar-heading">
                 Interface
            </div>

                    <li className="nav-item">
                        {/* eslint-disable-next-line jsx-a11y/anchor-is-valid */}
                    <a className="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapsePages"
                            aria-expanded="true" aria-controls="collapsePages">
                            <i className="fas fa-fw fa-folder"/>
                            <span>Employee Data</span>
                    </a>
                        <div id="collapsePages" className="collapse" aria-labelledby="headingPages" data-parent="#accordionSidebar">
                            <div className="bg-white py-2 collapse-inner rounded">                               
                                {/* Links to other pages */ }
                                <Link className="collapse-item nav-link" to="/addEmp">Add Emp</Link> 
                                <Link className="collapse-item nav-link" to="/delEmp">Delete Emp</Link>
                                <Link className="collapse-item nav-link" to="/findEmp">Search Emp</Link>
                                <Link className="collapse-item nav-link" to="/allEmp">All Emp</Link>
                            </div>
                        </div>
                        <hr className="sidebar-divider" />
                    </li>
                    <li className="nav-item">
                        <div className="nav-item" >
                            <Link className="nav-link" to="/schedule">
                                <i className="fas fa-fw fa-user-alt"/>
                                <span>Employee Schedule</span>
                            </Link>
                        </div>
                    </li>
                </ul>
            </nav>
        );
    }
}
