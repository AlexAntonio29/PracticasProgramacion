import logo from './logo2.svg';






import './App.css';
import { FormularioUsuario } from './FormularioUsuario.js';
import { FormularioDatosPersonales } from './FormularioDatosPersonales.js';
import { FormularioLocalizacion } from './FormularioLocalizacion.js';
import { FormularioPrivados } from './FormularioPrivados.js';
import { FormularioFinal } from './FormularioFinal.js';



function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
    
      
        
          <h1> Facebook</h1>

          <FormularioUsuario/>
          <FormularioDatosPersonales/>
          <FormularioLocalizacion/>
          <FormularioPrivados/>
          <FormularioFinal/>

         
       
      </header>
    </div>



  );
}

export default App;

