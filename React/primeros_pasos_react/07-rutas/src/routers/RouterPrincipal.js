import React, { Children } from 'react'
import {Routes, Route, createBrowserRouter, createRoutesFromElements, RouterProvider } from 'react-router-dom'
import { Inicio } from '../components/Inicio'
import { Contacto } from '../components/Contacto'
import { Articulo } from '../components/Articulo'
import {Error} from '../components/Error'
import { Frontend } from '../components/Frontend'

export const RouterPrincipal = () => {
  /*    const router = createBrowserRouter(
        createRoutesFromElements  (

            <Route path='/' element={<Frontend/>}>
                <Route path='/inicio' element={<Inicio/>}/>
                <Route path='/contacto' element={<Contacto/>}/>
                <Route path='/articulo' element={<Articulo/>}/>
                <Route path='*' element={(<Error/>)}/>

            </Route>
            
        )
    )*/

        const router = createBrowserRouter
        (
            [
                
            {path:'/', element: <Frontend />,
      children:
      [
        { index: true, element: <Inicio /> },
        { path:"/inicio", element:<Inicio />},
        { path:"/contacto", element:<Contacto />},
        { path:"/Articulo", element:<Articulo />},
        { path:"/*", element:<Error />}
    
    ]}
            ]
        )


  return (
    
<RouterProvider router={(router)}  future={{
    v7_startTransition: true,
  }}/>




  )
}
