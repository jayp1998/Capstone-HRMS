import React, { Component } from "react";
import axios from "axios";
import PropTypes from "prop-types";
import logo from "./logo.png";
import { Link } from "react-router-dom";

import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

import "jquery";
import "bootstrap";

export class loginPage extends Component {
  constructor(props) {
    super(props);

    this.setEmail = this.setEmail.bind(this);
    this.setpasswordResetEmail = this.setpasswordResetEmail.bind(this);
    this.setPassword = this.setPassword.bind(this);

    this.validateLoginForm = this.validateLoginForm.bind(this);
    this.validateForgotPasswordForm = this.validateForgotPasswordForm.bind(
      this
    );

    this.forgotPasswordClick = this.forgotPasswordClick.bind(this);
    this.rememberPasswordClick = this.rememberPasswordClick.bind(this);
    this.loginButtonClicked = this.loginButtonClicked.bind(this);
    this.forgotPasswordButtonClicked = this.forgotPasswordButtonClicked.bind(
      this
    );

    this.state = {
      email: "",
      passwordResetEmail: "",
      password: "",
      errors: {},
      isForgotPassword: false,
    };
  }

  static contextTypes = {
    router: PropTypes.object,
  };

  setEmail = (e) => {
    this.setState({ email: e.target.value });
  };

  setpasswordResetEmail = (e) => {
    this.setState({ passwordResetEmail: e.target.value });
  };

  setPassword = (e) => {
    this.setState({ password: e.target.value });
  };

  validateLoginForm(e) {
    if (this.state.email === "" || this.state.password === "") {
      return false;
    }
    return true;
  }

  validateForgotPasswordForm(e) {
    if (this.state.email === "") {
      return false;
    }
    return true;
  }

  loginButtonClicked(e) {
    e.preventDefault();

    let tokenRequestModel = {
      Email: this.state.email,
      Password: this.state.password,
    };

    axios.post("/api/users/login", tokenRequestModel).then((result) => {
      if (result.status === 200) {
        localStorage.setItem("currentUser", JSON.stringify(result.data));
        console.log("Login Completed");
        console.log(result);

        toast("Login Successfull..!!!", {
          position: "top-center",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
        this.props.history.push("/dashboard");
      } else {
        this.props.history.push("/");
        toast("Login Failed..!!!", {
          position: "top-center",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
        console.log("Login Failed");
      }
    });
  }

  forgotPasswordButtonClicked(e) {
    e.preventDefault();
    alert(1);
  }

  forgotPasswordClick = (e) => {
    this.setState({
      isForgotPassword: true,
      email: "",
    });
  };

  rememberPasswordClick = (e) => {
    this.setState({
      isForgotPassword: false,
      email: "",
    });
  };

  render() {
    return (
      <div className="bg-gradient-primary" style={{ display: "contents" }}>
        <div className="container">
          <div className="row justify-content-center">
            <div className="col-xl-10 col-lg-12 col-md-9">
              <div
                className="card o-hidden border-0 shadow-lg my-5"
                style={{ height: "auto" }}
              >
                <div className="card-body p-0">
                  <div className="row">
                    <div className="col-lg-6 d-none d-lg-block bg-login-image"></div>
                    <div className="col-lg-6">
                      <div className="p-5">
                        <div
                          className="text-center"
                          hidden={this.state.isForgotPassword}
                        >
                          <h1 className="h4 text-gray-900 mb-4">
                            Welcome Back!
                          </h1>
                        </div>
                        <div
                          className="text-center"
                          hidden={!this.state.isForgotPassword}
                        >
                          <h1 className="h4 text-gray-900 mb-2">
                            Forgot Your Password?
                          </h1>
                          <p className="mb-4">
                            We get it, stuff happens. Just enter your email
                            address below and we'll send you a link to reset
                            your password!
                          </p>
                        </div>
                        <form className="user">
                          <div className="form-group">
                            <input
                              type="email"
                              className="form-control form-control-user"
                              id="loginEmail"
                              aria-describedby="emailHelp"
                              placeholder="Enter Email Address..."
                              value={this.state.email}
                              onChange={this.setEmail}
                            />
                          </div>
                          <div
                            className="form-group"
                            hidden={this.state.isForgotPassword}
                          >
                            <input
                              type="password"
                              className="form-control form-control-user"
                              id="loginPassword"
                              placeholder="Password"
                              value={this.state.password}
                              onChange={this.setPassword}
                            />
                          </div>
                          <div
                            className="form-group"
                            hidden={this.state.isForgotPassword}
                          >
                            <div className="custom-control custom-checkbox small">
                              <input
                                type="checkbox"
                                className="custom-control-input"
                                id="customCheck"
                              />
                              <label className="custom-control-label">
                                Remember Me
                              </label>
                            </div>
                          </div>
                          <button
                            className="btn btn-primary btn-user btn-block btn-custom-btn"
                            onClick={this.loginButtonClicked}
                            disabled={!this.validateLoginForm()}
                            hidden={this.state.isForgotPassword}
                          >
                            Login
                          </button>
                          <button
                            className="btn btn-primary btn-user btn-block btn-custom-btn"
                            hidden={!this.state.isForgotPassword}
                            disabled={!this.validateForgotPasswordForm()}
                          >
                            Reset Password
                          </button>
                        </form>
                        <hr />
                        <div
                          className="text-center"
                          hidden={this.state.isForgotPassword}
                        >
                          <a
                            className="small"
                            style={{ cursor: "context-menu" }}
                            onClick={this.forgotPasswordClick}
                          >
                            Forgot Password?
                          </a>
                        </div>
                        <div
                          className="text-center"
                          hidden={!this.state.isForgotPassword}
                          onClick={this.rememberPasswordClick}
                        >
                          <a className="small">
                            Already have an account? Login !
                          </a>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}
