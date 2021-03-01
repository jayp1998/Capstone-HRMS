import React, {Component} from 'react';
import {Route} from 'react-router';
import {Layout} from './components/Layout';
import {loginPage} from './components/login/loginPage';
// IMPORTS FOR ADMIN PANEL
import {adminIndex} from './components/admin/index';
import {allEmp} from './components/admin/allEmp';
import {addEmp} from './components/admin/addEmp';
import {findEmp} from './components/admin/findEmp';
import {delEmp} from './components/admin/delEmp';
import {schedule} from "./components/admin/schedule";
//IMPORTS FOR EMPLOYEE PANEL
import {empIndex} from './components/employee/empIndex';
import './App.css';


export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={loginPage} />
                <Route path='/adminIndex' component={adminIndex} />
                <Route path='/allEmp' component={allEmp} />
                <Route path='/addEmp' component={addEmp} />
                <Route path='/findEmp' component={findEmp} />
                <Route path='/delEmp' component={delEmp} />
                <Route path='/empIndex' component={empIndex} />
                <Route path='/schedule' component={schedule}/>
            </Layout>
        );
    }
}
