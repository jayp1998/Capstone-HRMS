import React from 'react';
import {AddPayroll} from "./components/admin/AddPayroll";

// COMPONENTS OF ADMIN PANEL
const adminIndex = React.lazy(() => import('./components/admin/index'));
const allEmp = React.lazy(() => import('./components/admin/allEmp'));
const addEmp = React.lazy(() => import('./components/admin/addEmp'));
const findEmp = React.lazy(() => import('./components/admin/findEmp'));
const delEmp = React.lazy(() => import('./components/admin/delEmp'));
const schedule = React.lazy(()=>import('./components/admin/schedule'));
const leaveManagement = React.lazy(()=>import('./components/admin/leaveManagement'));
const UpdatePayroll = React.lazy(()=>import('./components/admin/AddPayroll'));
//const messagefromemployee = React.lazy(()=>import('./components/admin/messageList'));


// COMPONENTS OF EMPLOYEE PANEL
const empIndex = React.lazy(()=>import('./components/employee/empIndex'));
const events = React.lazy(()=>import('./components/employee/events'));
const leave = React.lazy(()=>import('./components/employee/leave'));
const payroll = React.lazy(()=>import('./components/employee/payroll'));
const holidays = React.lazy(() => import('./components/employee/holidays'));

const resetPassword  = React.lazy(() => import('./components/login/resetPassword'));

const routes = [
    { path: '/', exact: true, name: 'Login' },
    { path: '/resetPassword', name: 'resetPassword', component: resetPassword },
    { path: '/adminIndex', name: 'adminIndex', component: adminIndex },
    { path: '/allEmp', name: 'allEmp', component: allEmp },
    { path: '/addEmp', name: 'addEmp', component: addEmp },
    { path: '/findEmp', name: 'findEmp', component: findEmp },
    { path: '/delEmp', name: 'delEmp', component: delEmp },
    { path: '/schedule', name: 'schedule', component: schedule },
    { path: '/leaveManagement', name: 'schedule', component: leaveManagement },
    { path: '/UpdatePayroll', name: 'schedule', component: UpdatePayroll },


    //{ path: '/message', name: 'message', component: messagefromemployee},

    // EMPLOYEE SECTIONS ROUTES
    { path: '/empIndex', name: 'empIndex', component: empIndex },
    { path: '/events', name: 'empIndex', component: events },
    { path: '/leave', name: 'empIndex', component: leave },
    { path: '/payroll', name: 'empIndex', component: payroll },
    { path: '/holidays', name: 'holidays', component: holidays },


];

export default routes;
