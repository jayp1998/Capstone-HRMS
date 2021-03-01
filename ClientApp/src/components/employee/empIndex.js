import React, {Component} from 'react';

export class empIndex extends Component {
    constructor(props) {
        super(props);

        this.state = {
            username: '',
            password: '',
            isLogin: true,
            errors: {}
        }
    }
    render() {
        return (
            <div>
                <h1>
                    Welcome to the Employee Section
            </h1>
            </div>
        );
    }
}

