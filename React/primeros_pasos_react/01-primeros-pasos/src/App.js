import logo from './logo.svg';
import './App.css';

import Micomponente from './Micomponente';/*Aqui se logran importar lo que son los componentes dentro de El index principal (App.js) 
  por lo tanto es importante incorporarlos en esta Seccion*/

  
import SegComponente from './SegComponente';
import { TercComponente } from './TercComponente';
import { EventoOnclick } from './EventoOnclick';
import { EventoDoubleclick } from './EventoDoubleclick';
import { OnMouseEnter } from './OnMouseEnter';
{/*NOTA: Es muy imporante tener en cuenta que a la hora de incorporar lo que son los componentes debemos de tener en cuenta que 
  los componentes deben de iniciar con alguna letra mayuscula y por estetica es importante que no esten separados por ejemplos "MiComponente"

  Es para que pueda ser reconocidos por React.
  */}






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
       
     
<Micomponente/>{/*jsx que es la union de codigo de javascript con react 
                  en react se utiliza un componentes que son como bloques de codigo
                  que se encuntran almacenados dentro de otros archivos con el fin de que sea 
                  mucho mas estructurado y entendible el codigo.

                  En este ejemplo se crea un componente con el nombre de Micomponente que hace llamar a otro archivo .js con el 
                  fin de continuar con la intruccion proporcionada, el fin de esta manera de programar es para poder reutilizar el codigo
                   de manera mas eficiente y estructurada
*/}
<SegComponente/>

<TercComponente 

nombre="Alexis" 
apellidos="Antonio"
ficha={ficha_medica}/*Lo componentes igual que las funciones o metodos tienen la facilidad de poder enviar parametros dentro de esta
para que pueda trabajar con el archivo posterior en este caso TercComponente

tanto nombre como apellidos y ficha (que contiene otros 3 datos se mandan a TercComponente)
*/
/>


{/*Uso de Eventos */}

<h2>EventoOnclick</h2>
<EventoOnclick/>{/*Accion cuanto clickeas una vez*/}
<h2>EventoDoubleClick</h2>{/*Accion cuanto clickeas dos veces*/}
<EventoDoubleclick/>
<h2>EventoOnMouse</h2>{/*Accion cuanto pasas el cursor en el área*/}
<OnMouseEnter/>

    
      </header>
   
    </div>
  );
}

export default App;
