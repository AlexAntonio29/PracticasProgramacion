import React, { useEffect, useState } from 'react'
import { AvisoComponent } from './AvisoComponent';
import { AjaxComponent } from './AjaxComponent';

export const PruebaComponents = () => {

 const [usuario, setUsuario] =useState("Alexis Antonio");

 const [fecha, setFecha] = useState("01-01-1998");

 const [contador, setContador] = useState("0");

 const cambiarUsuario = e =>{

    let user = e.target.value;

    if(user=="") setUsuario("Alexis Antonio")
        else
    setUsuario(user);


 }

 const cambiarFecha = e =>{

    setFecha(new Date().toLocaleDateString());
 }

 //se ejecuta cuando cualquier componente u objeto cambie
 useEffect(()=>{

    console.log("Has realizado un cambio")
 });
//solo se ejecuta una vez, al cargar la página
 useEffect(()=>{

    console.log("Se ha cargado la página")
 },[]);

 //solo se ejecutar el usuario
 useEffect(()=>{

    console.log("Se ha cambiar el usuario")
 },[usuario]);

 useEffect(()=>{
    setContador(parseInt(contador)+1);
    console.log(contador);

 },[usuario,fecha])

  return (

   


    <div>
        
<h1>El efecto - Hook Use-Effect</h1>

<strong className={contador>=10? 'label':'label label-green'}>{usuario}</strong>

<p>
<input type='text' onChange={cambiarUsuario}  placeholder='Cambiar Nombre'></input>


</p>

<strong className={contador>=10? 'label':'label label-green'}>{fecha}</strong>

<button className='label-green' onClick={cambiarFecha}>cambiar Fechar</button>

{
   usuario=="ALEXIS" && <AvisoComponent/>
}




    </div>



  )
}
