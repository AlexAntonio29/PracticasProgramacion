import logo from './logo.svg';
import './App.css';

import Micomponente from './Micomponente';
import SegComponente from './SegComponente';
import { TercComponente } from './TercComponente';
import { EventoOnclick } from './EventoOnclick';
import { EventoDoubleclick } from './EventoDoubleclick';
import { OnMouseEnter } from './OnMouseEnter';






function App() {

let ficha_medica={

  edad:"21",
  altura:"1.61",
  tipo_sangre:"a+",


}

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Hola esta es mi primera pagina en React 
        </p>
       
    
        {//Con las llaves se puede utilizar javascript
        //Se agrega mi primer componente => Micomponente()
        }
       
     
<Micomponente/>
<SegComponente/>

<TercComponente 
nombre="Alexis" 
apellidos="Antonio"
ficha={ficha_medica}
/>


<h2>EventoOnclick</h2>
<EventoOnclick/>
<h2>EventoDoubleClick</h2>
<EventoDoubleclick/>
<h2>EventoOnMouse</h2>
<OnMouseEnter/>

    
      </header>
   
    </div>
  );
}

export default App;
