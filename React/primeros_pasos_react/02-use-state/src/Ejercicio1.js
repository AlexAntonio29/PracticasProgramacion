import React, { useState } from 'react'
import { Ejercicio1_1Input } from './Ejercicio1_1Input';


export const Ejercicio1 = (cosas) => {// al usar el comando raft se genera la estructura de react

let year= (new Date().getFullYear()); //variable tipo flecha que toma como variable la fecha de hoy
                                      //new Date es para tomar la fecha de hoy. y getFullYear para tomar el año
let [change=year, setChange]= useState(year);



const after = (e)=>{ //variable de tipo flecha en javascript

    setChange(change-1);
    
}

const next = (e)=>{

    setChange(change+1);
}

let ErrorChange =()=> {
  alert("No es un numero")
 document.getElementById("inputYear").value="";
 setChange(year);
}

let changetext = (e, textoFijo)=>{  !isNaN(document.getElementById("inputYear").value) ? setChange(textoFijo) : ErrorChange() ;

}
  return (
    <div>


        <button onClick={e=>after(e)}  style={{background:'white',color:'red',borderRadius:'10px'}}>Anterior</button>
        &nbsp;
           <strong>{change}</strong>
        &nbsp;
        <button onClick={e=>next(e)}  style={{background:'white', color:'red',borderRadius:'10px'}}>Siguiente</button>


        <h3>Modificar Fecha Manual</h3>

        <input  type='text' onChange={ e=> changetext(e, parseInt(e.target.value))} placeholder='introduce año'  id='inputYear'/>
        <hr/>
    </div>



  )
}


