//import { Component } from "react";

// class Consultas extends Component{
//     constructor (props){
//         super(props);
//         this.state ={
//             listaConsultas : [],
            
//         }
//     }


//     buscarConsultas = () =>  {
//         console.log ('agora vamos fazer a chamada da API')

//         // Faz a chamada para API usando o fetch 
//         fetch('http://localhost:5000/api/consulta')

//         //Fetch retorna uma Promisse que se resvolve em uma resposta { Respose}
//         // .then(resposta = console.log(resposta.json()))

//         // Define o tipo de dadeod do retorno da requisição (JSON)
//         .then(resposta => resposta.json())

//         //e atualiza  o state listaConsulta com os dados obtidos
//         .then(dados => this.setState({listaConsultas  : dados}))
//         // . then(dados => console.log(dados))

//         // Caso ocorra algum erro, mostra no console do navegador
//         .catch(erro => console.log(erro))
//     }

//     //Chama a função buscarConsulta() assim que o componete é renderizado

//     componentDidMount(){
//         this.buscarConsulta();
//     }

//  render(){
//      return(
//         <div>
//             <main>
//                 <section>
//                     {/* Lista de consultas */}
//                     <h2>Lista de Consultas</h2>
//                     <table>
//                         <thead>
//                             <tr></tr>
//                         </thead>

//                         <tbody>
//                         {
//                             this.state.listaConsultas.map( (consulta) => {
//                                 return (
//                                     <tr key={consulta.IdConsulta}>
//                                         <td>{consulta.IdConsulta}</td>
//                                         <td>{consulta.IdPaciente}</td>
//                                         <td>{consulta.IdSituacao}</td>
//                                         <td>{consulta.IdMedico}</td>
//                                         <td>{consulta.horaConsulta}</td>
//                                         <td>{consulta.dataConsulta}</td>
//                                         <td>{consulta.descricao}</td>
//                                     </tr>
//                                 )
//                             })
//                         }
//                         </tbody>

//                     </table>
//                 </section>
//             </main>
//         </div>
//      )
//  }
// }


// export default Consultas;
