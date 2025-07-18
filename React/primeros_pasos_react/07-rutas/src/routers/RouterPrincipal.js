import React from 'react'
import {Routes, Route, createBrowserRouter, createRoutesFromElements, RouterProvider } from 'react-router-dom'
import { Inicio } from '../components/Inicio'
import { Contacto } from '../components/Contacto'
import { Articulo } from '../components/Articulo'
import {Error} from '../components/Error'
import { Frontend } from '../components/Frontend'

export const RouterPrincipal = () => {
    const router = createBrowserRouter(
        createRoutesFromElements  (

            <Route path='/' element={<Frontend/>}>
                <Route path='/inicio' element={<Inicio/>}/>
                <Route path='/contacto' element={<Contacto/>}/>
                <Route path='/articulo' element={<Articulo/>}/>
                <Route path='*' element={(<Error/>)}/>

            </Route>
            
        )
    )


  return (
    
<RouterProvider router={(router)}/>




  )
}
