import { Component } from "react";

class Consulta extends Component{
    constructor (props){
        super(props);
        this.state ={
            listaConsultas : [],
            
        }
    }

    componentDidMount(){
        // codigo
    }

 render(){
     <div>
         <main>
             <section>
                 {/* Lista de consultas */}
                 <h2>Lista de Consultas</h2>
                 <table>
                     <thead>
                         <tr></tr>
                     </thead>

                     <tbody>
                        {
                            this.state.listaConsultas.map( (consulta) => {
                                return (
                                    <tr></tr>
                                )
                            })
                        }
                     </tbody>


                 </table>
             </section>
         </main>
     </div>
 }
}

export default Consulta;