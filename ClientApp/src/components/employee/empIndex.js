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
                    <div className="row">
                        <Leaveleft/>
                    </div>
                    <div className="row">
                        <SendMessage/>
                        <MessageFromAdmin/>
                    </div>
                </div>
            <Footer/>
            </div>
        );
    }
}

