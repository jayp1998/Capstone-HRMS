import React, {Component} from 'react';
import {Link} from 'react-router-dom';

export default class EMPNAV extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <nav className="admin__nav col-auto">
                <ul className="menu">
                    <li className="menu__title">Directories:</li>
                    <br/>
                    <li className="menu__item">
                        <Link className="menu__link" to="/empIndex">My Profile</Link>
                    </li>
                        <li className="menu__item">
                            <Link className="menu__link" to="/payroll">Payroll</Link>
                        </li>
                        <li className="menu__item">
                            <Link className="menu__link" to="/leave">Leave Management</Link>
                        </li>
                        <li className="menu__item">
                            <Link className="menu__link" to="/events">Events</Link>
                        </li>
                        <li className="menu__item">
                            <Link className="menu__link" to="/holidays">Holidays</Link>
                        </li>
                </ul>
            </nav>
        );
    }
}
