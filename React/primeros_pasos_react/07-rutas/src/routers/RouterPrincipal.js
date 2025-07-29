
import {createBrowserRouter, Navigate, RouterProvider } from 'react-router-dom'
import { Inicio } from '../components/Inicio'
import { Contacto } from '../components/Contacto'
import { Articulo } from '../components/Articulo'
import {Error} from '../components/Error'
import { Frontend } from '../components/Frontend'
import { Persona } from '../components/Persona'
import { PanelControl } from '../components/PanelControl'

import{InicioPanel} from '../components/panel/InicioPanel'
import{Gestionar} from '../components/panel/Gestionar'
import{Crear} from '../components/panel/Crear'
import{Acerca} from '../components/panel/Acerca'






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
                //la estructura del frontend o el index
            {path:'/', element: <Frontend />,
      children:
      [
        //los submenus de ese index
        { index: true, element: <Inicio /> },
        { path:"/inicio", element:<Inicio />},
        { path:"/contacto", element:<Contacto />},
        { path:"/Articulo", element:<Articulo />},
        { path:"/Persona", element: <Persona/>},
        { path:"/Persona/:nombre", element: <Persona/>},
        { path:"/Persona/:nombre/:apellido", element: <Persona/>},
        {path:"/redirigir", element:<Navigate to="/inicio"/>},
        {path:"/panel/*", element:<PanelControl/>,
          children:[
            {path:"inicio", element:<InicioPanel/>},
            {path:"crear-articulo", element:<Crear/>},
            {path:"gestionar-usuario", element:<Gestionar/>},
            {path:"acerca-de", element:<Acerca/>}
          ]
        },
        

        { path:"/*", element:<Error />}
    
    ]}
            ]
        )


  return (
   
//se usa RouterProvider para hacer uso del routerDoom y se llama a la constante router para que se ejecute
<RouterProvider router={(router)}  
 //se agrega future={{v7_startTransition: true,}} para cumplir la sintaxis del codigo de routerDom
future={{v7_startTransition: true,}}/>




  )
}
