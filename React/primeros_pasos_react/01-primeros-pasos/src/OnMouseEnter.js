import React from 'react'


const Action=(e,n)=>{

    console.log(n);
}



export const OnMouseEnter = () => {
  return (
    <div className='Mouse' onMouseEnter={e=>Action(e,"Entrando")} onMouseLeave={e=>Action(e,"Saliendo")} >OnMouseEnter</div>
  )
}
