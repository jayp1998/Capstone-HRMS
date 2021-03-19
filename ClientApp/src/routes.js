import React from 'react';

// COMPONENTS OF ADMIN PANEL
const adminIndex = React.lazy(() => import('./components/admin/index'));
const allEmp = React.lazy(() => import('./components/admin/allEmp'));
const addEmp = React.lazy(() => import('./components/admin/addEmp'));
const findEmp = React.lazy(() => import('./components/admin/findEmp'));
const delEmp = React.lazy(() => import('./components/admin/delEmp'));
const schedule = React.lazy(()=>import('./components/admin/schedule'));

// COMPONENTS OF EMPLOYEE PANEL
const empIndex = React.lazy(()=>import('./components/employee/empIndex'));
const events = React.lazy(()=>import('./components/employee/events'));
const leave = React.lazy(()=>import('./components/employee/leave'));
const payroll = React.lazy(()=>import('./components/employee/payroll'));
const holidays = React.lazy(()=>import('./components/employee/holidays'));

const routes = [
    { path: '/', exact: true, name: 'Login' },
    { path: '/adminIndex', name: 'adminIndex', component: adminIndex },
    { path: '/allEmp', name: 'allEmp', component: allEmp },
    { path: '/addEmp', name: 'addEmp', component: addEmp },
    { path: '/findEmp', name: 'findEmp', component: findEmp },
    { path: '/delEmp', name: 'delEmp', component: delEmp },
    { path: '/schedule', name: 'schedule', component: schedule },

    // EMPLOYEE SECTIONS ROUTES
    { path: '/empIndex', name: 'empIndex', component: empIndex },
    { path: '/events', name: 'empIndex', component: events },
    { path: '/leave', name: 'empIndex', component: leave },
    { path: '/payroll', name: 'empIndex', component: payroll },
    { path: '/holidays', name: 'holidays', component: holidays },


];

export default routes;
