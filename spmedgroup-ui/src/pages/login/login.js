import React, { Component} from 'react';
import axios from 'axios';

class Login extends Component {
    constructor(props){
      super (props);
        this.state = {
            email : '',
            senha: '',
            errorMensagem : '',
            isLoading : false
        }
    };

    // Função que faz a chamada para a API para realizar o login 
    efetuaLogin = (event) =>{
      // Ignora o comportamento padrão do navegador ( recarregar a página, por exemplo )
      event.preventDefault();

      // Remove a frase de erro do state erroMensagem e define que a requisição está em andamento
      this.setState({ errorMensagem : '', isLoading: true})


      // Define a URL e o corpo da requisição
      axios.post('http://localhost:5000/api/login', {
          email : this.state.email,
          senha : this.state.senha
      })
      // Verifica o retorno da requisição 
      .then(resposta => {
        // Caso o status code seja 200,
        if (resposta.status === 200 ){
          // salva o valor do token no localStorage,
            localStorage.setItem('usuario-login', resposta.data.token)


            // exige o valor do token no console do navegador 
            console.log('Meu token é:' + resposta.data.token)
        }
      })

      // Caso haja um erro,
      .catch(() => {
        // define o valor do state errorMensagem com uma mensegem personalizada e que a requisição terminou 
        this.setState({ errorMensagem : 'E-mail ou senha inválidos! Tente novamente.' })
      })
    }

    AtualizaStateCampo = (campo) => {
      this.setState({ [campo.target.name] : campo.target.value })
    }

    render(){
      return(
        <div>
          <main>
            <section>
              <p> Pagina de Login</p>

                {/* Faz a chamada para a função de login quando o botão é pressionado  */}

              <form onSubmit={this.efetuaLogin}>
              <input
                  // E-mail
                  type="text"
                  name="email"
                  //Define que o imput email recebe o valor do state email
                  value={this.state.email}
                  // Faz a chamada para a função que atualiza o state, conforme o usuario altera o valor do input
                  onChange={this.AtualizaStateCampo}
                    placeholder="username"              
                />

                  <input
                  // Senha
                  type="password"
                  name="senha"
                  //Define que o imput senha recebe o valor do state email
                  value={this.state.senha}
                  // Faz a chamada para a função que atualiza o state, conforme o usuario altera o valor do input
                  onChange={this.AtualizaStateCampo}
                    placeholder="password"              
                />

                {/* Exibe a mensagem de erroao tentar logar com credenciais inválidas */}
                <p style={{ color : 'red' }}> {this.state.errorMensagem}</p>

                {/* Verifica se a requisição está em andamento se estiver, desabilita o click do botão */}

                 {
                   // Caso isLoanding seja true, renderiza o botão desabilitado com o texto 'Loanding...'
                   this.state.isLoading === true &&
                   <button type="submit" disabled>Loanding...</button>
                 }

                 {
                    // Caso seja false, rendereriza o botão habilitado com o texto 'Login'
                    this.state.isLoading === false &&
                    <button
                    type="submit"
                    disabled={this.state.email === ''  || this.state.senha === '' ?  'none' : ''}
                    >
                      Login
                    </button>

                 }


                <button type="submit">
                    Login
                </button>
              </form>
            </section>
          </main>
        </div>
      )
    }
}

export default Login;