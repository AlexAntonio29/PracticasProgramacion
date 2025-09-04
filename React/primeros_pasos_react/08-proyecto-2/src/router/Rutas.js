import React from 'react'
import {RouterProvider,createBrowserRouter, Navigate} from 'react-router-dom'
import { Inicio } from '../components/Inicio'
import { Portafolio } from '../components/Portafolio';
import { Curriculum } from '../components/Curriculum';
import { Servicio } from '../components/Servicio';
import { Contacto } from '../components/Contacto';
import { Frontend } from '../components/Frontend';
import { Proyecto } from '../components/Proyecto';
import { ErrorPagina } from '../components/ErrorPagina';

export const Rutas = () => {

    const router= createBrowserRouter(
        [
            {
                path:'/', element:<Frontend/>,
                children:[
                    {index:true, element:<Navigate to="/inicio"/>},
                    {path:"/inicio", element:<Inicio/>},
                    {path:"/curriculum", element:<Curriculum/>},
                    {path:"/servicio", element:<Servicio/>},
                    {path:"/contacto", element:<Contacto/>},
                    {path:"/portafolio", element:<Portafolio/>},
                    {path:"/portafolio/:id", element:<Proyecto/> , errorElement:<ErrorPagina/>},
                    
                    {path:"/*", element:<h1 >Error 404</h1>}
                ]

            }
        ]
    );

  return (
    <div>

        <RouterProvider router={(router)} future={{v7_startTransition:true}}/>
        

    </div>
  )
}
