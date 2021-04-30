import React, { Component, Fragment } from "react";
import "react-toastify/dist/ReactToastify.css";
import "jquery";
import "bootstrap";

class Footer extends Component {
  constructor(props) {
    super(props);
  }

  render() {
    return (
      <Fragment>
        <footer className="sticky-footer bg-white">
          <div className="container my-auto">
            <div className="copyright text-center my-auto">
              <span>Copyright &copy; Your Website 2020</span>
            </div>
          </div>
        </footer>
      </Fragment>
    );
  }
}

export default Footer;
