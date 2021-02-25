import React, { Component } from 'react';
import axios from 'axios';
import { NavMenu } from './NavMenu';

export class Dashboard extends Component {
    constructor(props){
        super(props);
    }

    render () {
        return(
            <NavMenu></NavMenu>
        );
    }
}