import React, { Component } from 'react';

export class Employee extends Component {
    

    constructor(props) {
        super(props);

        this.state = { value: '' };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);

    }

    handleChange(event) {
        this.setState({ value: event.target.value, loggedIn: event.target.value });
    }

    handleSubmit(event) {
        alert('A name was submitted: ' + this.state.value);
        event.preventDefault();



        //get employee profile

    }


    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <label>
                  Employee ID:
          <input type="text" value={this.state.value} onChange={this.handleChange} />
                </label>
                <input type="submit" value="Go" />
            </form>


        );
    }
}
