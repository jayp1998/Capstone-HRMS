import React, {Component} from 'react';
import axios from 'axios';
import PropTypes from 'prop-types';
import './login.css'
import logo from './logo.png';
import { Link } from "react-router-dom";

export class loginPage extends Component {
    constructor(props) {
        super(props);

        this.validateForm = this.validateForm.bind(this);
        this.adminButtonClicked = this.adminButtonClicked.bind(this);
        this.employeeButtonClicked = this.employeeButtonClicked.bind(this);
        this.setEmail = this.setEmail.bind(this);
        this.setPassword = this.setPassword.bind(this);

        this.state = {
            email: '',
            password: '',
            errors: {}
        }
    }

    static contextTypes = {
        router: PropTypes.object,
    }

    setEmail(e) {
        this.setState({
            email: e.target.value
        });
    }

    setPassword(e) {
        this.setState({
            password: e.target.value
        });
    }

    validateForm(e) {
        return this.state.email.length > 0 && this.state.password.length > 0;
    }

    adminButtonClicked(e) {
        e.preventDefault();
        let loginObject = {
            email: this.state.email,
            password: this.state.password,
        }
        axios.post("api/Users/token/", loginObject).then(result => {
            if (result.status === 200) {
                console.log(result);
                this.props.history.push("/adminIndex");
            } else {
                this.props.history.push("/");
                console.log("Login Failed");
            }
            console.log(result);
        })
    }

    employeeButtonClicked(e) {
        e.preventDefault();
        let loginObject = {
            username: this.state.username,
            password: this.state.password,
        }
        axios.post("api/Users/token/", loginObject).then(result => {
            if (result.status === 200) {
                localStorage.setItem('currentUser', JSON.stringify(result.data));
                console.log("Login Completed");
                this.props.history.push("/empIndex");
            } else {
                this.props.history.push("/");
                console.log("Login Failed");
            }
            console.log(result);
        })
    }

    render() {
        return (
            <section>
                <div className="limiter">
                    <div className="container-login100">
                        <div className="wrap-login100">
                            <div className="login100-pic js-tilt" data-tilt>
                                <img src={logo}></img>
                            </div>
                            <form className="login100-form" onSubmit={this.handleSubmit}>
                                <span className="login100-form-title">
                                    Member Login<br />
                                </span>
                                <div className="wrap-input100">
                                    <input
                                        className="input100"
                                        type="email"
                                        name="email"
                                        placeholder="Email"
                                        value={this.state.email}
                                        onChange={this.setEmail}
                                        required />
                                </div>
                                <div className="wrap-input100" >
                                    <input
                                        className="input100"
                                        type="password"
                                        name="pass"
                                        placeholder="Password"
                                        value={this.state.password}
                                        onChange={this.setPassword}
                                        required />
                                </div>
                                <Link to="/login/resetPassword">Forgot password?</Link>
                                <div className="container-login100-form-btn">
                                    <button
                                        id="employeeButton"
                                        className="login100-form-btn"
                                        onClick={this.employeeButtonClicked}
                                        disabled={!this.validateForm()}>
                                        Login
                                    </button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </section>
        );
    }
}
