import React from 'react'
import { Outlet } from 'react-router-dom'
import { HeaderNav } from './layout/HeaderNav'
import { Footer } from './layout/Footer'

export const Frontend = () => {
  return (
    <div>

       
        {/*HEAD*/}
    
        <HeaderNav/>
       
        
        {/*BODY*/}
        <section className='content'>
          
          <Outlet/>
        </section>
        

        
        {/*FOOTER*/}
        <Footer/>
    

    </div>
  )
}
