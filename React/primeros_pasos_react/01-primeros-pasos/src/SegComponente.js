import React from 'react'
{//Al agregar un componente es importante agregar la primera inicial con MAYUSCULA, DE LO CONTRARIO DA ERROR O NO ES RECONOCIDO
}
export default function SegComponente() {

    let libros=["Juegos del hambre","Juego de tronos","La biblia"];
   // let libros=[]


  return (
    <div>
           
      <h1>Lista de libros</h1>

            {
               
                libros.length>=1 ? ( <ul>
                    {
               libros.map((libro, indice)=>{

                return <li key={indice}> {libro}</li>
               })
               }
               </ul>)

                :(
                    <p>No hay libros</p>
                )
                
                }

        

            
    </div>
  )
}
