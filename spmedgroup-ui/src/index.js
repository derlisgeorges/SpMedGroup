import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect} from 'react-router-dom';

import './index.css';

import App from './pages/home/App';
import Consultas from './pages/consultas/Consultas';
import novaConsulta from './pages/novaConsulta/novaConsulta';
import novaDescricao from './pages/novaDescricao/novaDescricao';
import Login from './pages/login/login';


import NotFound from './pages/notFound/notFound';

import reportWebVitals from './reportWebVitals';





const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={App}/>                 {/* Home*/}
        <Route path="/consultas" component={Consultas}/>        {/* Consultas */}
        <Route path="/login" component={Login}/>                {/* Login*/}
        <Route path="/notfound" component={NotFound}/>          {/* Not Found */}
        <Route path="novaconsulta" component={novaConsulta}/>   {/* Nova Consulta */}
        <Route path="novadescricao" component={novaDescricao}/> {/* Nova Descriao */}
        <Redirect to="/notfound" component={NotFound}/>         {/* Redireciona para NotFound caso não encontre nenhuma rota */}
      </Switch>
    </div>
  </Router>
)
ReactDOM.render(routing, document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
