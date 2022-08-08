import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <>
                <div>
                    <h1>Controle de Estoque</h1>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <a href="#" class="btn btn-primary">Adicionar Produto</a>
                            <a href="#" class="btn btn-primary">Remover Produto</a>
                            <a href="#" class="btn btn-primary">Verificar Estoque</a>
                        </div>
                    </div>
                </div>
               </>
        );
    }
}

                  