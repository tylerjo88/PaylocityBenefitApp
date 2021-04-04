import React, { Component } from 'react';

export class Employee extends Component {
    

    constructor(props) {
        super(props);

        this.state = { value: '',  data: []};

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
        fetch('https://localhost:44361/employee/1', { mode: 'cors' })
            //.then(response => response.json())
            .then(data => console.log(data))
            //.then(data => {
            //    this.setState({
            //        data: data
            //    });
            //})
            .catch(resp => {
                console.error(resp);
            });

      console.log(this.state.data);

    }


    render() {
        const { data } = this.state.data

        
        return (
            <form onSubmit={this.handleSubmit}>
                <label>
                    Employee ID:
          <input type="text" value={this.state.value} onChange={this.handleChange} />
                </label>
                <input type="submit" value="Go" />

                <h1>{data}</h1>
            </form>
        );
        //const result = data.map((entry, index) => {
        //    return <li key={index}>{entry}</li>
        //})

        //return <ul>{result}</ul>
 
    }
}

