

import './App.css';
import { EjemploRef1 } from './components/EjemploRef1';
import { EjemploRefTime } from './components/EjemploRefTime';

/*
El use-Ref Nos sirve como su nombre indica para hacer referencia a un objeto y que podamos interactuar 
con el como si de un id se tratase
*/

function App() {

  return (
    <div className="App">
      <EjemploRef1/>
      
      <EjemploRefTime/>
      
    </div>
  );
}

export default App;
