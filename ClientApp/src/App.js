import React, {Component} from 'react';
import {Route} from 'react-router';
import {Layout} from './components/Layout';
import {loginPage} from './components/login/loginPage';
import {resetPassword} from "./components/login/resetPassword";
// IMPORTS FOR ADMIN PANEL
import {adminIndex} from './components/admin/index';
import {allEmp} from './components/admin/allEmp';
import {addEmp} from './components/admin/addEmp';
import {findEmp} from './components/admin/findEmp';
import {delEmp} from './components/admin/delEmp';
import {schedule} from "./components/admin/schedule";
//import {MessageList} from './components/admin/messageList'
//IMPORTS FOR EMPLOYEE PANEL
import {empIndex} from './components/employee/empIndex';
import {Events} from './components/employee/events';
import {Payroll} from "./components/employee/payroll";
import {Leave} from "./components/employee/leave";
import {Holidays} from "./components/employee/holidays";
import './App.css';


export default class App extends Component {
    static displayName = Component.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={loginPage} />
                <Route exact path='/resetPassword' component={resetPassword} />
                <Route path='/adminIndex' component={adminIndex} />
                <Route path='/allEmp' component={allEmp} />
                <Route path='/addEmp' component={addEmp} />
                <Route path='/findEmp' component={findEmp} />
                <Route path='/delEmp' component={delEmp} />
                <Route path='/schedule' component={schedule}/>

                <Route path='/empIndex' component={empIndex} />
                <Route path='/payroll' component={Payroll} />
                <Route path='/events' component={Events} />
                <Route path='/leave' component={Leave} />
                <Route path='/holidays' component={Holidays} />
            </Layout>
        );
    }
}
