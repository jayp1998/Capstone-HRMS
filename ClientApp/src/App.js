import React, { Component } from "react";
import { loginPage } from "./components/login/loginPage";
import { resetPassword } from "./components/login/resetPassword";
import { dashboard } from "./components/login/dashboard";
import { department } from "./components/admin/department";

import { Switch, Route } from "react-router-dom";
// IMPORTS FOR ADMIN PANEL
import { adminIndex } from "./components/admin/index";
import { allEmp } from "./components/admin/allEmp";
import { addEmp } from "./components/admin/addEmp";
import { findEmp } from "./components/admin/findEmp";
import { delEmp } from "./components/admin/delEmp";
import { schedule } from "./components/admin/schedule";
import { LeaveManagement } from "./components/admin/leaveManagement";
import { AddPayroll } from "./components/admin/AddPayroll";
import { MainSchedule } from "./components/employee/MainSchedule";
import { Myprofile } from "./components/employee/myprofile";
import { Editprofile } from "./components/employee/editprofile";

//import {MessageList} from './components/admin/messageList'
//IMPORTS FOR EMPLOYEE PANEL
import { empIndex } from "./components/employee/empIndex";
import { Events } from "./components/employee/events";
import { Payroll } from "./components/employee/payroll";
import { Leave } from "./components/employee/leave";
import { Holidays } from "./components/employee/holidays";
import $ from "jquery";

export default class App extends Component {
    static displayName = Component.name;

    componentDidMount() {
        // Toggle the side navigation
        $("#sidebarToggle, #sidebarToggleTop").on("click", function (e) {
            $("body").toggleClass("sidebar-toggled");
            $(".sidebar").toggleClass("toggled");
            if ($(".sidebar").hasClass("toggled")) {
                $(".sidebar .collapse").collapse("hide");
            }
        });

        // Close any open menu accordions when window is resized below 768px
        $(window).resize(function () {
            if ($(window).width() < 768) {
                $(".sidebar .collapse").collapse("hide");
            }

            // Toggle the side navigation when window is resized below 480px
            if ($(window).width() < 480 && !$(".sidebar").hasClass("toggled")) {
                $("body").addClass("sidebar-toggled");
                $(".sidebar").addClass("toggled");
                $(".sidebar .collapse").collapse("hide");
            }
        });

        // Prevent the content wrapper from scrolling when the fixed side navigation hovered over
        $("body.fixed-nav .sidebar").on(
            "mousewheel DOMMouseScroll wheel",
            function (e) {
                if ($(window).width() > 768) {
                    var e0 = e.originalEvent,
                        delta = e0.wheelDelta || -e0.detail;
                    this.scrollTop += (delta < 0 ? 1 : -1) * 30;
                    e.preventDefault();
                }
            }
        );

        // Scroll to top button appear
        $(document).on("scroll", function () {
            var scrollDistance = $(this).scrollTop();
            if (scrollDistance > 100) {
                $(".scroll-to-top").fadeIn();
            } else {
                $(".scroll-to-top").fadeOut();
            }
        });

        // Smooth scrolling using jQuery easing
        $(document).on("click", "a.scroll-to-top", function (e) {
            var $anchor = $(this);
            $("html, body")
                .stop()
                .animate(
                    {
                        scrollTop: $($anchor.attr("href")).offset().top,
                    },
                    1000,
                    "easeInOutExpo"
                );
            e.preventDefault();
        });
    }

    render() {
        return (
            <Switch>
                <Route exact path="/" component={loginPage} />
                <Route exact path="/resetPassword" component={resetPassword} />
                <Route exact path="/dashboard" component={dashboard} />
                <Route path="/adminIndex" component={adminIndex} />
                <Route path="/allEmp" component={allEmp} />
                <Route path="/depart" component={department} />
                <Route path="/addEmp" component={addEmp} />
                <Route path="/findEmp" component={findEmp} />
                <Route path="/delEmp" component={delEmp} />
                <Route path="/schedule" component={schedule} />
                <Route path="/leaveManagement" component={LeaveManagement} />
                <Route path="/UpdatePayroll" component={AddPayroll} />
                <Route path="/empIndex" component={empIndex} />
                <Route path="/payroll" component={Payroll} />
                <Route path="/events" component={Events} />
                <Route path="/leave" component={Leave} />
                <Route path="/holidays" component={Holidays} />
                <Route path="/myschedule" component={MainSchedule} />
                <Route path="/myprofile" component={Myprofile} />
                <Route path="/editprofile" component={Editprofile} />
            </Switch>
        );
    }
}
