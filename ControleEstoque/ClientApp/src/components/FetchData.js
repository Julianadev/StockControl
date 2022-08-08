import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
      super(props);
      this.state = { inventory: [], loading: true };
  }

  componentDidMount() {
    this.populateInventoryData();
  }

  static renderInventoryTable(inventory) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Entrada</th>
            <th>Saida</th>
            <th>Total</th>
          </tr>
        </thead>
        <tbody>
          {inventory.map(inventory =>
            <tr key={inventory.date}>
              <td>{inventory.date}</td>
              <td>{inventory.entrada}</td>
              <td>{inventory.saida}</td>
              <td>{inventory.total}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderInventoryTable(this.state.inventory);

    return (
      <div>
        <h1 id="tabelLabel" >Produtos</h1>
        <p>This component demonstrates a data de entrada e saáda dos produtos.</p>
        {contents}
      </div>
    );
  }

  async populateInventoryData() {
    const response = await fetch('inventory');
    const data = await response.json();
    this.setState({ inventory: data, loading: false });
  }
}
