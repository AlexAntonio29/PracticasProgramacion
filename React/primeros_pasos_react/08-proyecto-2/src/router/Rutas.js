import React from 'react'
import {RouterProvider,createBrowserRouter} from 'react-router-dom'
import { Inicio } from '../components/Inicio'
import { Portafolio } from '../components/Portafolio';
import { Curriculum } from '../components/Curriculum';
import { Servicio } from '../components/Servicio';
import { Contacto } from '../components/Contacto';
import { Frontend } from '../components/Frontend';

export const Rutas = () => {

    const router= createBrowserRouter(
        [
            {
                path:'/', element:<Frontend/>,
                children:[
                    {index:true, element:<Inicio/>},
                    {path:"/inicio", element:<Inicio/>},
                    {path:"/portafolio", element:<Portafolio/>},
                    {path:"/curriculum", element:<Curriculum/>},
                    {path:"/servicio", element:<Servicio/>},
                    {path:"/contacto", element:<Contacto/>}
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
