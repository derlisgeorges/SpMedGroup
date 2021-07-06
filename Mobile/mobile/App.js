import React, { Component } from 'react';
import { FlatList, Image, StyleSheet, Text, View } from 'react-native';


import api from './src/services/api'


export default class App extends Component{
  constructor(props) {
    super (props);
    this.state ={
      listaConsulta:[]
    };
  }



  buscarConsulta = async () => {
    const resposta = await api.get ('/consulta');
    const dadosDaApi = resposta.data;
    this.setState ({ listaConsulta:dadosDaApi});
  };


  componentDidMount(){
    //realiza a chamada da api
    this.buscarConsulta();
  }

  render () {
    return (
      <View style={styles.container}>
        <text>{'Consulta'.toUpperCase()}</text>
        <View>
          <FlatList
          contentContainerStyle={styles.mainBodyConteudo}
          data={this.state.listaConsulta}
          keyExtractor={ (item) => item.nomeConsulta}
          renderItem={this.renderizaItem}
          />
        </View>
      </View>
    );
  }

  renderizaItem = ({ item }) => (
    <View style={styles.flatItemLinha}>
      <View>
        <Text>{item.dataConsulta}</Text>
        <Text>{item.horaConsulta}</Text>
        <Text>{item.descricao}</Text>
      </View>
    </View>
  );


}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },

  // conteúdo da lista 
  mainBodyConteudo: {
    paddingTop:30,
    paddingRight: 50,
    paddingLeft:50,
  },

});
