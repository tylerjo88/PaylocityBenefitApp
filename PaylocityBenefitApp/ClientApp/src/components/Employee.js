import React, { Component } from 'react';

export class Employee extends Component {
    

    constructor(props) {
        super(props);

        this.state = { value: '',  employee: []};

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);

    }

    handleChange(event) {
        this.setState({ value: event.target.value });
    }

    handleSubmit(event) {
        alert('A name was submitted: ' + this.state.value);
        event.preventDefault();

          //get employee profile
        fetch('https://localhost:44361/employee/' + this.state.value, { mode: 'cors' })
            .then(response => response.text())
            .then(data => {
                this.setState({
                    employee: data
                });

                console.log("in then: " + data)

                console.log("in then two: " + this.state.employee)
            })
            .catch(resp => {
                console.error(resp);
            });

    }



    render() {

        console.log("in render: " + this.state.employee)
        console.log("in render test: " + this.state.employee.employeeId)
        
        return (
            <div>
            <form onSubmit={this.handleSubmit}>
                <label>
                    Employee ID:
          <input type="text" value={this.state.value} onChange={this.handleChange} />
                </label>
                <input type="submit" value="Go" />
               
                </form>

                <h1>{this.state.employee}</h1>

                <p>employee id: {this.state.employee.employeeId}</p>
                <p>first name: {this.state.employee.firstName}</p>

                {this.state.employee.map((employee) => (
                    <p>{employee.employeeId}</p>
                ))}


                {/*<div className="col">*/}
                {/*    <h1>Mi Casa</h1>*/}
                {/*    <p>This is my house y&apos;all!</p>*/}
                {/*    {this.state.employee.map(home => <div>{home.firstName}</div>)}*/}
                {/*</div>*/}
            </div>



        );

 
    }
}

