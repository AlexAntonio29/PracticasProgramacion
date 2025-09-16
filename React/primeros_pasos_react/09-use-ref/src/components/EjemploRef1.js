
import { useRef, useState } from 'react';

export const EjemploRef1 = () => {
    
  const nombre= useRef("Alex");
  const apellido= useRef("Antonio");
  const edad= useRef("23");
  const miCuadro=useRef();

  
  const [cuadro, setCuadro]=useState(false);
  const [comentario,setComentario]=useState("Datos no cargados");


  const enviar=(e)=>{
      e.preventDefault();
    console.log(nombre.current.value);//como se puede ver, es mas facil porder interactuar con un objeto
    console.log(apellido.current.value);
    console.log(edad.current.value);
    /*
    De lo contrario, lo podemos hacer de la siguiente manera
    let datos= e.target;
    console.log(datos.nombre.value);
    
    */

    if(nombre.current.value!==""&&apellido.current.value!==""&&edad.current.value!==""){
      setCuadro(1);

    }
    


    

  
  }


  const cargar=()=>{
    
      let { current: caja } = miCuadro;
    console.log(caja);
    caja.classList.add("complete"); 
    setComentario("Datos Envidados");

  }
  return (
    <div>


        <h1>Use-REF</h1>
      
    <form onSubmit={enviar}>
      <input ref={nombre} name='nombre' type='text' placeholder='Nombre'></input><br/>
      <input ref={apellido} type='text' placeholder='Apellido'></input><br/>
      <input ref={edad} type='text' placeholder='Edad'></input><br/>

      <button>Enviar Formulario</button>
    </form>

    {
      cuadro && <div  className='cuadro'>
        <h3>Nombre: {nombre.current.value}</h3>
        <h3>Apellido: {apellido.current.value}</h3>
        <h3>Edad: {edad.current.value} años</h3>

        <button onClick={cargar}>Enviar Datos</button>

        <br/>
  <strong>{comentario}</strong>
  <span  ref={miCuadro}>&#10004;</span>

        

      </div>
    }
    </div>
  )
}
