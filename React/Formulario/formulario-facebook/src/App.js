import logo from './logo2.svg';







import './App.css';
import { FormularioUsuario } from './FormularioUsuario.js';
import { FormularioDatosPersonales } from './FormularioDatosPersonales.js';
import { FormularioLocalizacion } from './FormularioLocalizacion.js';
import { FormularioPrivados } from './FormularioPrivados.js';
import { FormularioFinal } from './FormularioFinal.js';
import React, { useState } from 'react'
import './Formulario.css';
import { CSSTransition } from 'react-transition-group';


function App() {

  const [isVisibleUsuario, setIsVisibleUsuario] = useState(true);
  const [isVisiblePersonales, setIsVisiblePersonales] = useState(false);
  const [isVisibleLocalizacion, setIsVisibleLoc] = useState(false);
  const [isVisiblePrivados, setIsVisisblePrivados] =useState (false);
  const [isVisibleFinal, setIsVisibleFinal]= useState(false);


  const[usuario,setUsuario]=useState('');



  let actionVisibilityUsuario=(e)=>{

    if(usuario==''){
      alert("No puedes dejar el apartado vacío")
    }else{

    setIsVisibleUsuario(!isVisibleUsuario);
    setIsVisiblePersonales(true);
  }
}

  let actionVisibilityPersonales=()=>{
    setIsVisiblePersonales(!isVisiblePersonales);
    setIsVisibleLoc(true);
  }

  let actionVisiblityLoc=(e)=>{
    setIsVisibleLoc(!isVisibleLocalizacion);
    setIsVisisblePrivados(true);
  }

  let actionVisiblityPriv=(e)=>{
    setIsVisisblePrivados(!isVisiblePrivados);
    setIsVisibleFinal(true);

  }

  let actionVisibilityFinal=(e)=>{

    alert("Final");
  }



  let functionReciveUser=(e)=>{

setUsuario(e);

  }

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
    
      
        
          <h1> Facebook</h1>

        <div className='designFormulario'>
        <CSSTransition
        in={isVisibleUsuario}
        timeout={0}
        classNames="fade"
        unmountOnExit
      >
        
        <FormularioUsuario reciveUsuario={ functionReciveUser}/>
         
         </CSSTransition>
<CSSTransition
        in={isVisiblePersonales}
        timeout={0}
        classNames="fade"
        unmountOnExit
      >

        <FormularioDatosPersonales/>
         
         </CSSTransition>

         <CSSTransition
        in={isVisibleLocalizacion}
        timeout={0}
        classNames="fade"
        unmountOnExit
      >

        <FormularioLocalizacion/>
         
         </CSSTransition>

         <CSSTransition
        in={isVisiblePrivados}
        timeout={0}
        classNames="fade"
        unmountOnExit
      >

        <FormularioPrivados/>
         
         </CSSTransition>

         <CSSTransition
        in={isVisibleFinal}
        timeout={0}
        classNames="fade"
        unmountOnExit
      >

        <FormularioFinal/>
         
         </CSSTransition>
         {isVisibleUsuario && <button  className='design_button' onClick={e=>actionVisibilityUsuario(true)}>Continuar</button> }
          {isVisiblePersonales && <button  className='design_button' onClick={e=>actionVisibilityPersonales(true)}>Continuar</button> }
          {isVisibleLocalizacion && <button  className='design_button' onClick={e=>actionVisiblityLoc(true)}>Continuar</button> }
          {isVisiblePrivados && <button  className='design_button' onClick={e=>actionVisiblityPriv(true)}>Continuar</button> }
          {isVisibleFinal && <button  className='design_button' onClick={e=>actionVisibilityFinal(true)}>Continuar</button> }

        </div>

      </header>
    </div>



  );
}

export default App;

