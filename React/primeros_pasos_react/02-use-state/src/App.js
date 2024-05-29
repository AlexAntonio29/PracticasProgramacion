import logo from './logo.svg';
import './App.css';

import { Ejercicio1 } from './Ejercicio1';

function App() {



  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>



       <h1>EL ESTADO ES REACT - HOOK UseState</h1>


       <h2>Ejercicio 1</h2>


       <Ejercicio1/>
      
      </header>
    </div>
  );
}

export default App;
