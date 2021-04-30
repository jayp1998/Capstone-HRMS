import React, { Component, Fragment } from "react";
import Sidebar from "../login/sidebar";
import Header from "../login/header";
import Footer from "../login/footer";
import profile from "./img/profile.png";
import { faPencilAlt, faDelete } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

export class allEmp extends Component {
  constructor(props) {
    super(props);

    this.addEmployeeButtonClicked = this.addEmployeeButtonClicked.bind(this);
    this.closeAddEmployeeWindowClicked = this.closeAddEmployeeWindowClicked.bind(
      this
    );

    this.state = {
      isAddEmploeeButtonClicked: false,
    };
  }

  addEmployeeButtonClicked(e) {
    this.setState({ isAddEmploeeButtonClicked: true });
  }

  closeAddEmployeeWindowClicked(e) {
    this.setState({ isAddEmploeeButtonClicked: false });
  }

  render() {
    let AddNewEmployee;

    return (
      <Fragment>
        <Sidebar />
        <div id="content-wrapper" className="d-flex flex-column">
          <div id="content">
            <Header></Header>
            <div
              className="container-fluid"
              hidden={this.state.isAddEmploeeButtonClicked}
            >
              <div className="d-sm-flex align-items-center justify-content-between mb-4">
                <h1 className="h3 mb-0 text-gray-800">Add Employee</h1>
                <a
                  className="btn btn-warning btn-icon-split"
                  onClick={this.closeAddEmployeeWindowClicked}
                >
                  <span className="icon text-white-50">
                    <i className="fa fa-close"></i>
                  </span>
                </a>
              </div>

              <div className="row card card-body">
                <form className="">
                  <div className="form-group d-flex justify-content-center">
                    <label
                      for="labelFirstname"
                      className="col-sm-2 col-form-label"
                    >
                      First Name:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="text"
                        className="form-control"
                        id="inputFirstname"
                        value="First Name"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label
                      for="labelLastname"
                      className="col-sm-2 col-form-label"
                    >
                      Last Name:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="text"
                        className="form-control"
                        id="inputLastname"
                        placeholder="Last Name"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label
                      for="labelUsername"
                      className="col-sm-2 col-form-label"
                    >
                      Username:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="text"
                        className="form-control"
                        id="inputUsername"
                        placeholder="Username"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label for="labelEmail" className="col-sm-2 col-form-label">
                      Email:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="email"
                        className="form-control"
                        id="inputEmail"
                        placeholder="test@email.com"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label
                      for="labelPassword"
                      className="col-sm-2 col-form-label"
                    >
                      Password:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="text"
                        className="form-control"
                        id="inputPassword"
                        placeholder="Password"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label
                      for="labelConfirmPassword"
                      className="col-sm-2 col-form-label"
                    >
                      Confirm Password:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="text"
                        className="form-control"
                        id="inputConfirmPassword"
                        placeholder="Confirm Password"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label
                      for="labelJoiningDate"
                      className="col-sm-2 col-form-label"
                    >
                      Joining Date:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="date"
                        className="form-control"
                        id="inputJoiningDate"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label for="labelPhone" className="col-sm-2 col-form-label">
                      Phone:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="tel"
                        className="form-control"
                        id="inputPhone"
                        placeholder="401-432-5656"
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <label
                      for="labelDesignation"
                      className="col-sm-2 col-form-label"
                    >
                      Designation:
                    </label>
                    <div className="col-sm-6">
                      <div className="dropdown">
                        <button
                          className="btn btn-secondary dropdown-toggle"
                          type="button"
                          id="dropdownMenuButton"
                          data-toggle="dropdown"
                          aria-haspopup="true"
                          aria-expanded="false"
                        >
                          Dropdown button
                        </button>
                        <div
                          className="dropdown-menu"
                          aria-labelledby="dropdownMenuButton"
                        >
                          <a className="dropdown-item" href="#">
                            Action
                          </a>
                          <a className="dropdown-item" href="#">
                            Another action
                          </a>
                          <a className="dropdown-item" href="#">
                            Something else here
                          </a>
                        </div>
                      </div>
                    </div>
                  </div>
                </form>
              </div>
            </div>

            <div
              className="container-fluid"
              hidden={!this.state.isAddEmploeeButtonClicked}
            >
              <div className="d-sm-flex align-items-center justify-content-between mb-4">
                <h1 className="h3 mb-0 text-gray-800">Employee</h1>
                <a
                  className="btn btn-warning btn-icon-split"
                  onClick={this.addEmployeeButtonClicked}
                >
                  <span className="icon text-white-50">
                    <i className="fa fa-plus"></i>
                  </span>
                  <span className="text">Add Employee</span>
                </a>
              </div>
              <div className="row">
                <div className="col-xl-3 col-md-6 mb-4">
                  <div className="card border-left-info shadow h-100 py-2">
                    <div className="card-body">
                      <div className="row no-gutters align-items-center">
                        <div
                          className="col mr-2"
                          style={{
                            textAlign: "center",
                            wordBreak: "break-all",
                          }}
                        >
                          <div className="text-xs font-weight-bold text-primary text-uppercase mb-1">
                            <img
                              className="img-profile rounded-circle"
                              src={profile}
                              style={{ width: "50%" }}
                            ></img>
                          </div>
                          <div className="h5 mb-0 font-weight-bold text-gray-800">
                            Douglas McGee
                          </div>
                          <a
                            href="#"
                            className="btn btn-primary btn-circle btn-sm"
                            style={{ margin: "2px" }}
                          >
                            <FontAwesomeIcon icon={faPencilAlt} />
                          </a>
                          <a
                            href="#"
                            className="btn btn-primary btn-circle btn-sm"
                            style={{ margin: "2px" }}
                          >
                            <i className="fas fa-trash-alt"></i>
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
      </Fragment>
    );
  }
}
