import React from 'react';

// COMPONENTS OF ADMIN PANEL
const adminIndex = React.lazy(() => import('./components/admin/index'));
const allEmp = React.lazy(() => import('./components/admin/allEmp'));
const addEmp = React.lazy(() => import('./components/admin/addEmp'));
const findEmp = React.lazy(() => import('./components/admin/findEmp'));
const delEmp = React.lazy(() => import('./components/admin/delEmp'));


// COMPONENTS OF EMPLOYEE PANEL
const empIndex = React.lazy(()=>import('./components/employee/empIndex'));

const routes = [
    { path: '/', exact: true, name: 'Login' },
    { path: '/adminIndex', name: 'adminIndex', component: adminIndex },
    { path: '/allEmp', name: 'allEmp', component: allEmp },
    { path: '/addEmp', name: 'addEmp', component: addEmp },
    { path: '/findEmp', name: 'findEmp', component: findEmp },
    { path: '/delEmp', name: 'delEmp', component: delEmp },
    { path: '/empIndex', name: 'empIndex', component: empIndex },

];

export default routes;
