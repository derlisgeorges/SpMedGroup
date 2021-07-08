// Faz a importação do pacote 
import axios from "axios";

// Define a constante api para a chamada de requisições 
const api = axios.create({
    // Define a URL base para as requisições à Api
    baseURL : 'http://localhost:5000/api',
});

// Exporta a constante para o uso em outros arquivos do projeto 
export default api;
