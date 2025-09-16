import React, { useEffect, useRef, useState } from 'react'

export const EjemploRefTime = () => {


  /*
  EN ESTA PRACTICA VEMOS LA IMPORTANCIA DEL USE REF CUANDO UTILIZAMOS UN USE_EFFECT
  ESTO SIGNIFICA QUE SI USAMOS ESTE HOOK, EN MUCHAS OCASIONES QUEREMOS OBTENER UN VALOR
  FINAL AL MOMENTO, Y ESO EL USE_STATE NO PUEDE HACER YA QUE SU VALOR VA CAMBIANDO CONSTANTEMENTE
  POR LO TANTO ES MUY VARIABLE, PERO CON EL USE_REF SI REACCIONA DE TAL MANERA QUE TE DA EL VALOR
  FINAL QUE DESEAMOS OBTENER...
  AQUI ESTA UN EJEMPLO:
  */
    const [contar,setContar]=useState(0);//LA USAMOS PARA PRIMERAMENTE ACTUALIZAR LOS VALORES

    const contadorRef=useRef(contar);


    useEffect(()=>{//usamos el UseRef para simular el ejemplo
      contadorRef.current=contar;//le damos el valor del UseState al UseRef para poder obtener el valor real
      setTimeout(()=>{

        console.log(contadorRef.current);

      },2000)//agregamos cada 2 segundos ya que trabaja en milisegundos

    },[contar]);


    const contador=(e)=>{

      setContar(contar+ 1);
    }



  return (

    

    <div>
        <hr/>

        <h2>Ejemplos useRef con tiempo</h2>

        <h3>Contador: {contar} </h3>

        <button onClick={contador}>Sumar Valor</button>

    </div>
  )
}
