import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home.component';
import { Dashboard } from './components/Dashboard.component';
import { MyPeople } from './components/Mypeople.component'
import './App.css';

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                    <Route exact path='/' component={Home} />
                    <Route path='/dashboard' component={Dashboard} />
                    <Route path='/people' component={MyPeople} />
            </Layout>
        );
    }
}
