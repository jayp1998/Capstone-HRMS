import React, {Component} from 'react';
import EMPNAV from "./empnav";
import Header from "./header";
import Footer from "./footer";
import './css/events.css';
export class Events extends Component {
    constructor(props) {
        super(props);

    }

    render() {
        return (
            <div className="admin">
                <Header/>
                <EMPNAV/>
                <div className="admin__main">
                    <div id="calendar-wrap">
                        <header>
                            <h1>March 2021</h1>
                        </header>
                        <div id="calendar">
                            <ul className="weekdays">
                                <li>Sunday</li>
                                <li>Monday</li>
                                <li>Tuesday</li>
                                <li>Wednesday</li>
                                <li>Thursday</li>
                                <li>Friday</li>
                                <li>Saturday</li>
                            </ul>

                            <ul className="days">
                                <li className="day other-month">
                                    <div className="date">27</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">28</div>
                                    <div className="event">
                                        <div className="event-desc">
                                            HTML 5 lecture with Brad Traversy from Eduonix
                                        </div>
                                    </div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">29</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">30</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">31</div>
                                </li>
                                <li className="day">
                                    <div className="date">1</div>
                                </li>
                                <li className="day">
                                    <div className="date">2</div>
                                    <div className="event">
                                        <div className="event-desc">
                                            Career development @ Community College room #402
                                        </div>
                                    </div>
                                </li>
                            </ul>


                            <ul className="days">
                                <li className="day">
                                    <div className="date">3</div>
                                </li>
                                <li className="day">
                                    <div className="date">4</div>
                                </li>
                                <li className="day">
                                    <div className="date">5</div>
                                </li>
                                <li className="day">
                                    <div className="date">6</div>
                                </li>
                                <li className="day">
                                    <div className="date">7</div>
                                    <div className="event">
                                        <div className="event-desc">
                                            Group Project meetup
                                        </div>
                                    </div>
                                </li>
                                <li className="day">
                                    <div className="date">8</div>
                                </li>
                                <li className="day">
                                    <div className="date">9</div>
                                </li>
                            </ul>


                            <ul className="days">
                                <li className="day">
                                    <div className="date">10</div>
                                </li>
                                <li className="day">
                                    <div className="date">11</div>
                                </li>
                                <li className="day">
                                    <div className="date">12</div>
                                </li>
                                <li className="day">
                                    <div className="date">13</div>
                                </li>
                                <li className="day">
                                    <div className="date">14</div>
                                    <div className="event">
                                        <div className="event-desc">
                                            Board Meeting
                                        </div>
                                    </div>
                                </li>
                                <li className="day">
                                    <div className="date">15</div>
                                </li>
                                <li className="day">
                                    <div className="date">16</div>
                                </li>
                            </ul>


                            <ul className="days">
                                <li className="day">
                                    <div className="date">17</div>
                                </li>
                                <li className="day">
                                    <div className="date">18</div>
                                </li>
                                <li className="day">
                                    <div className="date">19</div>
                                </li>
                                <li className="day">
                                    <div className="date">20</div>
                                </li>
                                <li className="day">
                                    <div className="date">21</div>
                                </li>
                                <li className="day">
                                    <div className="date">22</div>
                                    <div className="event">
                                        <div className="event-desc">
                                            Conference call
                                        </div>
                                    </div>
                                </li>
                                <li className="day">
                                    <div className="date">23</div>
                                </li>
                            </ul>


                            <ul className="days">
                                <li className="day">
                                    <div className="date">24</div>
                                </li>
                                <li className="day">
                                    <div className="date">25</div>
                                    <div className="event">
                                        <div className="event-desc">
                                            Conference Call
                                        </div>
                                    </div>
                                </li>
                                <li className="day">
                                    <div className="date">26</div>
                                </li>
                                <li className="day">
                                    <div className="date">27</div>
                                </li>
                                <li className="day">
                                    <div className="date">28</div>
                                </li>
                                <li className="day">
                                    <div className="date">29</div>
                                </li>
                                <li className="day">
                                    <div className="date">30</div>
                                </li>
                            </ul>

                            <ul className="days">
                                <li className="day">
                                    <div className="date">31</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">1</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">2</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">3</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">4</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">5</div>
                                </li>
                                <li className="day other-month">
                                    <div className="date">6</div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <Footer/>
            </div>
        );
    }
}
