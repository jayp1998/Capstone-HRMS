import React from "react";
import { AddPayroll } from "./components/admin/AddPayroll";

// COMPONENTS OF ADMIN PANEL
const adminIndex = React.lazy(() => import("./components/admin/index"));
const allEmp = React.lazy(() => import("./components/admin/allEmp"));
const addEmp = React.lazy(() => import("./components/admin/addEmp"));
const findEmp = React.lazy(() => import("./components/admin/findEmp"));
const delEmp = React.lazy(() => import("./components/admin/delEmp"));
const schedule = React.lazy(() => import("./components/admin/schedule"));
const leaveManagement = React.lazy(() =>
    import("./components/admin/leaveManagement")
);
const UpdatePayroll = React.lazy(() => import("./components/admin/AddPayroll"));
//const messagefromemployee = React.lazy(()=>import('./components/admin/messageList'));

// COMPONENTS OF EMPLOYEE PANEL
const empIndex = React.lazy(() => import("./components/employee/empIndex"));
const events = React.lazy(() => import("./components/employee/events"));
const leave = React.lazy(() => import("./components/employee/leave"));
const payroll = React.lazy(() => import("./components/employee/payroll"));
const holidays = React.lazy(() => import("./components/employee/holidays"));
const MainSchedule = React.lazy(() =>
    import("./components/employee/MainSchedule")
);
const MyProfile = React.lazy(() => import("./components/employee/myprofile"));
const EditProfile = React.lazy(() =>
    import("./components/employee/editprofile")
);
const resetPassword = React.lazy(() =>
    import("./components/login/resetPassword")
);
const dashboard = React.lazy(() => import("./components/login/dashboard"));
const department = React.lazy(() => import("./components/admin/department"));

const routes = [
    { path: "/", exact: true, name: "Login" },
    { path: "/resetPassword", name: "resetPassword", component: resetPassword },
    { path: "/dashboard", name: "dashboard", component: dashboard },
    { path: "/adminIndex", name: "adminIndex", component: adminIndex },
    { path: "/allEmp", name: "allEmp", component: allEmp },
    { path: "/depart", name: "department", component: department },
    { path: "/addEmp", name: "addEmp", component: addEmp },
    { path: "/findEmp", name: "findEmp", component: findEmp },
    { path: "/delEmp", name: "delEmp", component: delEmp },
    { path: "/schedule", name: "schedule", component: schedule },
    { path: "/leaveManagement", name: "schedule", component: leaveManagement },
    { path: "/UpdatePayroll", name: "schedule", component: UpdatePayroll },

    //{ path: '/message', name: 'message', component: messagefromemployee},

    // EMPLOYEE SECTIONS ROUTES
    { path: "/empIndex", name: "empIndex", component: empIndex },
    { path: "/events", name: "empIndex", component: events },
    { path: "/leave", name: "empIndex", component: leave },
    { path: "/payroll", name: "empIndex", component: payroll },
    { path: "/holidays", name: "holidays", component: holidays },
    { path: "/myprofile", name: "holidays", component: MyProfile },
    { path: "/myprofile", name: "holidays", component: MyProfile },
    { path: "/editprofile", name: "holidays", component: EditProfile },
];

export default routes;
