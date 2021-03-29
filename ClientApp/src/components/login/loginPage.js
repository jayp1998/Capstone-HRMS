import React, {Component} from 'react';
import axios from 'axios';
import PropTypes from 'prop-types';
import './login.css'
import logo from './logo.png';


export class loginPage extends Component {
    constructor(props) {
        super(props);

        this.validateForm = this.validateForm.bind(this);
        this.adminButtonClicked = this.adminButtonClicked.bind(this);
        this.employeeButtonClicked = this.employeeButtonClicked.bind(this);
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



    adminButtonClicked(e) {
        e.preventDefault();
        let loginObject = {
            username: this.state.username,
            password: this.state.password,
        }
        axios.post("api/Users/login/", loginObject).then(result => {
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
        axios.post("/api/login", loginObject).then(result => {
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
                                        type="text"
                                        name="username"
                                        placeholder="UserName"
                                        value={this.state.username}
                                        onChange={this.setUsername}
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
                                <div className="container-login100-form-btn">
                                    <button
                                        id="employeeButton"
                                        className="login100-form-btn"
                                        onClick={this.employeeButtonClicked}
                                        disabled={!this.validateForm()}
                                    >
                                        Employee
                                    </button>
                                </div>
                                <div className="container-login100-form-btn">
                                    <button
                                        className="login100-form-btn"
                                        id="adminButton"
                                        onClick={this.adminButtonClicked}
                                        disabled={!this.validateForm()}
                                    >
                                        Admin
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
