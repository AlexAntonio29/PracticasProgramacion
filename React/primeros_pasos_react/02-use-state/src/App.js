import logo from './logo.svg';
import './App.css';

import { Ejercicio1 } from './Ejercicio1';
import { RetroAlimentacionEjercicioUseState } from './RetroAlimentacionEjercicioUseState';

function App() {



  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        



       <h1>EL ESTADO ES REACT - HOOK UseState</h1>


       <h2>Ejercicio 1</h2>


       {/*<Ejercicio1/>  va directamente al componente Ejercicio1.js*/}
      <RetroAlimentacionEjercicioUseState/>{/*Retroalimentracion*/ }
      </header>
    </div>
  );
}

export default App;
