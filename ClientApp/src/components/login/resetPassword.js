import React, {Component} from 'react';
import axios from 'axios';
import PropTypes from 'prop-types';
import './login.css'
import logo from './logo.png';
import { Link } from "react-router-dom";

import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

export class resetPassword extends Component {
    handleSubmit;
    constructor(props) {
        super(props);
        this.ResetPassword = this.ResetPassword.bind(this);

    }
    ResetPassword(e) {

        e.preventDefault();

    }
    render() {
        return (
            <section>
                <ToastContainer
                    position="top-center"
                    autoClose={5000}
                    hideProgressBar={false}
                    newestOnTop={false}
                    closeOnClick
                    rtl={false}
                    pauseOnFocusLoss
                    draggable
                    pauseOnHover
                />
                <div className="row">
                    <div className="limiter">
                        <div className="container-login100">
                            <div className="wrap-login100">
                                <div className="login100-pic js-tilt" data-tilt>
                                    <img src={logo}></img>
                                </div>
                                <form className="login100-form" onSubmit={this.handleSubmit}>
                                <span className="login100-form-title">
                                    Reset Password<br />
                                </span>
                                    <div className="wrap-input100">
                                        <input
                                            className="input100"
                                            type="email"
                                            name="email"
                                            placeholder="Email"
                                            required />
                                    </div>
                                    <div className="container-login100-form-btn">
                                        <button
                                            id="employeeButton"
                                            className="login100-form-btn"
                                            onClick={this.ResetPassword}>
                                            Reset
                                        </button>
                                        <br/>
                                        <Link to="/">Back to Login</Link>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        );
    }
}
