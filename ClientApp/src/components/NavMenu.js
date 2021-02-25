import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import $ from 'jquery';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);

        this.state = {
            collapsed: true,
            homePageLink: '/dashboard',
            backgroundImage: 'url(/images/bg_1.jpg)'
        };

        var pathname = window.location.pathname;
        if (pathname) {
            var parts = pathname.split('/');
            if (parts[parts.length - 1]) {
                var classname = string.concat("'", parts[parts.length - 1], "'");
                document.getElementsByClassName(classname).style.backgroundColor = "white";
            }
        }
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }
    
    componentDidMount() {
        var fullHeight = function () {
            $('.js-fullheight').css('height', $(window).height());
            $(window).resize(function () {
                $('.js-fullheight').css('height', $(window).height());
            });

        };
        fullHeight();
        $('#sidebarCollapse').on('click', function () {
            $('#sidebar').toggleClass('active');
        });
    }

    render() {
        return (
            <header>
                <div className="wrapper d-flex align-items-stretch">
                    <nav id="sidebar">
                        <div className="custom-menu">
                            <button type="button" id="sidebarCollapse" className="btn btn-primary">
                            </button>
                        </div>
                        <div className="img bg-wrap text-center py-4" style={{ backgroundImage: this.state.backgroundImage }}>
                            <div className="user-logo">
                                <div className="img" style={{ backgroundImage: this.state.backgroundImage}}></div>
                                <h3>Catriona Henderson</h3>
                            </div>
                        </div>
                        <ul className="list-unstyled components mb-5">
                            <li className="Home">
                                <a href="#"><span className="fa fa-home mr-3"></span> Home</a>
                            </li>
                            <li className="MyPeople">
                                <a href="/people"><span className="fa fa-download mr-3 notif"></span> My People</a>
                            </li>
                            <li className="Test">
                                <a href="/people"><span className="fa fa-download mr-3 notif"></span> Test</a>
                            </li>
                            <li className="Test">
                                <a href="/people"><span className="fa fa-download mr-3 notif"></span> Test</a>
                            </li>
                            <li className="Test">
                                <a href="/people"><span className="fa fa-download mr-3 notif"></span> Test</a>
                            </li>
                            <li className="Test">
                                <a href="/people"><span className="fa fa-download mr-3 notif"></span> Test</a>
                            </li>
                            <li className="SignOut">
                                <a href="#"><span className="fa fa-sign-out mr-3"></span> Sign Out</a>
                            </li>
                        </ul>

                    </nav>
                </div>
            </header>
        );
    }
}
