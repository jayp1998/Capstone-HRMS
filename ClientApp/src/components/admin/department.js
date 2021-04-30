import React, { Component, Fragment } from "react";
import "react-toastify/dist/ReactToastify.css";
import "jquery";
import "bootstrap";
import axios from "axios";
import Sidebar from "../login/sidebar";
import Header from "../login/header";
import { makeStyles } from "@material-ui/core/styles";
import Table from "@material-ui/core/Table";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableContainer from "@material-ui/core/TableContainer";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import Paper from "@material-ui/core/Paper";

// const useStyles = makeStyles({
//   table: {
//     minWidth: 650,
//   },
// });

// const classes = useStyles();

export class department extends Component {
  constructor(props) {
    super(props);

    this.displayAllDepartments = this.displayAllDepartments.bind(this);
    this.addDepartmentButtonClicked = this.addDepartmentButtonClicked.bind(
      this
    );
    this.closeAddDepartmentButtonClicked = this.closeAddDepartmentButtonClicked.bind(
      this
    );
    this.createDepartmentButtonClicked = this.createDepartmentButtonClicked.bind(
      this
    );
    this.setDepartmentName = this.setDepartmentName.bind(this);
    this.editButtonClicked = this.editButtonClicked(this);
    this.deleteuttonClicked = this.deleteuttonClicked(this);

    this.state = {
      isAddDepartmentButtonClicked: false,
      departmentName: "",
      departmentFormNotification: "",
      rows: [],
    };
  }

  componentDidMount() {
    window.addEventListener("load", this.displayAllDepartments());
  }

  addDepartmentButtonClicked() {
    this.setState({ isAddDepartmentButtonClicked: true });
  }

  closeAddDepartmentButtonClicked() {
    this.setState({ isAddDepartmentButtonClicked: false });
    this.displayAllDepartments();
  }

  displayAllDepartments() {
    axios.get("/api/Department/GetAllDepartments").then((result) => {
      var temp = [];
      if (result.status === 200 && result.data) {
        for (var i = 0; i < result.data.length; i++) {
          temp.push(
            this.createData(
              result.data[i].departmentId,
              result.data[i].departmentName,
              i + 1
            )
          );
        }
        this.setState({ rows: temp });
      }
      console.log(this.state.rows);
    });
  }

  createData(Id, name, rowIndex) {
    return { Id, name, rowIndex };
  }

  setDepartmentName(e) {
    this.setState({ departmentName: e.target.value });
  }

  createDepartmentButtonClicked(e) {
    e.preventDefault();

    if (this.state.departmentName === "") {
      alert("Please add department name");
      return;
    }

    let model = {
      DepartmentName: this.state.departmentName,
    };

    axios.post("/api/Department/add", model).then((result) => {
      if (result.status === 201) {
        alert("Department added successfully!!");
      } else if (result.status === 422) {
        alert("Department already exists");
      } else {
        alert("Error");
      }
      this.setState({ departmentName: "" });
    });
  }

  editButtonClicked(e) {
    console.log(e);
  }

  deleteuttonClicked(e) {}

  render() {
    return (
      <Fragment>
        <Sidebar></Sidebar>
        <div id="content-wrapper" className="d-flex flex-column">
          <div id="content">
            <Header></Header>
            <div
              className="container-fluid"
              hidden={this.state.isAddDepartmentButtonClicked}
            >
              <div className="d-sm-flex align-items-center justify-content-between mb-4">
                <h1 className="h3 mb-0 text-gray-800">Department</h1>
                <a
                  className="btn btn-warning btn-icon-split"
                  onClick={this.addDepartmentButtonClicked}
                >
                  <span className="icon text-white-50">
                    <i className="fa fa-plus"></i>
                  </span>
                  <span className="text">Add</span>
                </a>
              </div>
              <div className="row">
                <div className="card card-body">
                  <TableContainer component={Paper} style={{ width: "100%" }}>
                    <Table aria-label="table">
                      <TableHead>
                        <TableRow>
                          <TableCell style={{ width: "20%" }}>Id</TableCell>
                          <TableCell style={{ width: "60%" }}>
                            Department Name
                          </TableCell>
                          <TableCell style={{ width: "20%" }}>Action</TableCell>
                        </TableRow>
                      </TableHead>
                      <TableBody>
                        {this.state.rows.map((row) => (
                          <TableRow key={row.Id}>
                            <TableCell
                              component="th"
                              scope="row"
                              style={{ width: "20%" }}
                            >
                              {row.rowIndex}
                            </TableCell>
                            <TableCell style={{ width: "60%" }}>
                              {row.name}
                            </TableCell>
                            <TableCell style={{ width: "20%", padding: "0" }}>
                              <a
                                className="btn"
                                onClick={this.editButtonClicked}
                              >
                                <span className="icon">
                                  <i className="fa fa-edit"></i>
                                </span>
                              </a>
                              <a
                                className="btn"
                                onClick={this.deleteButtonClicked}
                              >
                                <span className="icon">
                                  <i className="fa fa-trash"></i>
                                </span>
                              </a>
                            </TableCell>
                          </TableRow>
                        ))}
                      </TableBody>
                    </Table>
                  </TableContainer>
                </div>
              </div>
            </div>
            <div
              className="container-fluid"
              hidden={!this.state.isAddDepartmentButtonClicked}
            >
              <div className="d-sm-flex align-items-center justify-content-between mb-4">
                <h1 className="h3 mb-0 text-gray-800">Add Department</h1>
                <a
                  className="btn btn-warning btn-icon-split"
                  onClick={this.closeAddDepartmentButtonClicked}
                >
                  <span className="icon text-white-50">
                    <i className="fa fa-close"></i>
                  </span>
                </a>
              </div>
              <div className="row">
                <form className="card card-body">
                  <span style={{ color: "red" }}>
                    {this.state.departmentFormNotification}
                  </span>
                  <div className="form-group d-flex justify-content-center">
                    <label className="col-sm-2 col-form-label">
                      Department Name <span style={{ color: "red" }}>*</span>:
                    </label>
                    <div className="col-sm-6">
                      <input
                        type="text"
                        className="form-control"
                        id="inputDepartmentname"
                        placeholder="Department Name"
                        value={this.state.departmentName}
                        onChange={this.setDepartmentName}
                      />
                    </div>
                  </div>
                  <div className="form-group d-flex justify-content-center">
                    <button
                      className="btn btn-warning btn-icon-split"
                      onClick={this.createDepartmentButtonClicked}
                    >
                      <span className="text">Create Department</span>
                    </button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </Fragment>
    );
  }
}
