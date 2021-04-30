import React, { Component, Fragment } from "react";
import "react-toastify/dist/ReactToastify.css";
import "jquery";
import "bootstrap";
import Sidebar from "./sidebar";
import Header from "./header";
import Footer from "./footer";

export class dashboard extends Component {
  constructor(props) {
    super(props);
  }

  render() {
    return (
      <Fragment>
        <Sidebar />
        <div id="content-wrapper" class="d-flex flex-column">
          <div id="content">
            <Header></Header>
            <Footer></Footer>
          </div>
        </div>
      </Fragment>
    );
  }
}
