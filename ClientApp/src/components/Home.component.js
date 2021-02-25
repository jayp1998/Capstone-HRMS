import React, { Component } from 'react';
import PasswordStrengthBar from 'react-password-strength-bar';
import axios from 'axios';
import PropTypes from 'prop-types';
import { Redirect } from 'react-router-dom';

export class Home extends Component {
    constructor(props) {
        super(props);

        this.validateForm = this.validateForm.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.setUsername = this.setUsername.bind(this);
        this.setPassword = this.setPassword.bind(this);

        this.state = {
            username: '',
            password: '',
            errors: {}
        }
    }

    static contextTypes = {
        router: PropTypes.object,
    }

    setUsername(e) {
        this.setState({
            username: e.target.value
        });
    }

    setPassword(e) {
        this.setState({
            password: e.target.value
        });
    }

    validateForm(e) {
        return this.state.username.length > 0 && this.state.password.length > 0;
    }

    handleSubmit(e) {
        e.preventDefault();
        let loginObject = {
            username: this.state.username,
            password: this.state.password,
        }

        axios.post("api/Users/Login", loginObject).then(result => {
            if (result.data == "" || result.data == undefined) {
                this.props.history.push("/");
            } else {
                localStorage.setItem('currentUser', JSON.stringify(result.data));
                this.props.history.push("/Dashboard");
            }
            console.log(result);
        })
    }

    render() {
        return (
            <div className="container">
                <div className="row">
                    <div className="col-sm">
                    </div>
                    <div className="col-sm">
                        <form id="signin" onSubmit={this.handleSubmit}>
                            <h3 style={{ textAlign: "center" }}>Sign In</h3>
                            <div className="form-group">
                                <label>UserName</label>
                                <input
                                    className="form-control"
                                    placeholder="Enter username"
                                    value={this.state.username}
                                    onChange={this.setUsername} />
                            </div>

                            <div className="form-group">
                                <label>Password</label>
                                <input
                                    type="password"
                                    className="form-control"
                                    placeholder="Enter password"
                                    value={this.state.password}
                                    onChange={this.setPassword} />
                                {/* <PasswordStrengthBar password={this.state.password} /> */}
                            </div>

                            <div className="form-group">
                                <div className="custom-control custom-checkbox">
                                    <input type="checkbox" className="custom-control-input" id="customCheck1" />
                                    <label className="custom-control-label" htmlFor="customCheck1">Remember me</label>
                                </div>
                            </div>

                            <button type="submit" className="btn btn-primary btn-block" disabled={!this.validateForm()}>Submit</button>
                            <p className="forgot-password text-right">
                                Forgot <a href="#">password?</a>
                            </p>
                        </form>
                    </div>
                    <div className="col-sm">
                    </div>
                </div>
            </div>
        );
    }
}
