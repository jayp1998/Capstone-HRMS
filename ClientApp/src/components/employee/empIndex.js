import React, {Component} from 'react';
import './css/style.css';
import 'bootstrap/dist/css/bootstrap.min.css';

import Header from "./header";
import EMPNAV from "./empnav";
import Footer from "./footer";
import EmployeeDetails from "./smallComp/employeeDetails";
import Leaveleft from "./smallComp/Leaveleft";
import SendMessage from "./smallComp/sendMessage";
import MessageFromAdmin from "./smallComp/MessageFromAdmin";
import Myschedule from "./smallComp/myschedule";

export class empIndex extends Component {
    constructor(props) {
        super(props);

        this.state = {
            username: '',
            password: '',
            isLogin: true,
            errors: {}
        }
    }
    render() {
        return (
            <div className="admin">
                <Header/>
                <EMPNAV/>
                <div className="admin__main">

                    <EmployeeDetails/>
                    <div className="col-xl-12 col-lg-5">
                    <div className="row">
                        <Leaveleft/>
                        <Myschedule/>
                    </div>
                    </div>
                    <div className="col-xl-12 col-lg-5">
                    <div className="row">
                        <SendMessage/>
                        <MessageFromAdmin/>
                    </div>
                    </div>
                </div>
            <Footer/>
            </div>
        );
    }
}

