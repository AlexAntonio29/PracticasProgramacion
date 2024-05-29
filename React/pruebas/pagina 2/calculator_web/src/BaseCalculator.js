import React from 'react'
import { Action_button } from './Action_button'

export const BaseCalculator = () => {


  const actionB=(e,n)=>{

   
    alert(n);

  }



  return (
    <div>
  

    <section className='base'>




    <section className='res'><div className='resultado'>0</div></section>
  
    <button className='B1' onClick={e=>actionB(e , "1")}>1</button>
    <button className='B2' onClick={e=>actionB(e , "2")}>2</button>
    <button className='B3' onClick={e=>actionB(e , "3")}>3</button>
    <button className='B4' onClick={e=>actionB(e , "4")}>4</button>
    <button className='B5' onClick={e=>actionB(e , "5")}>5</button>
    <button className='B6' onClick={e=>actionB(e , "6")}>6</button>
    <button className='B7' onClick={e=>actionB(e , "7")}>7</button>
    <button className='B8' onClick={e=>actionB(e , "8")}>8</button>
    <button className='B9' onClick={e=>actionB(e , "9")}>9</button>   
    

    </section>

    </div>
  )
}
