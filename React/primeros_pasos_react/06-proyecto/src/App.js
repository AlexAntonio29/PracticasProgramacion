import { useState } from "react";
import { Buscador } from "./components/Buscador";
import { Crear } from "./components/Crear";
import { Listado } from "./components/Listado";




function App() {

    const [listadoState, setListadoState] = useState([]);
    
  return (
   <div className="layout">
        {/*CABECERA DE LA PAGINA */}
        <header className="header">
            <div className="logo">
                <div className="play"></div>
            </div>
            <h1>MisPelis</h1>

        </header>

        {/*BARRA DE NAVEGACION*/}

        <nav className="nav">

            <ul>
                <li><a href="/#">Inicio</a></li>
                <li><a href="/#">Peliculas</a></li>
                <li><a href="/#">Blog</a></li>
                <li><a href="/#">Contacto</a></li>
            </ul>
        </nav>
        {/*CONTENIDO PRINCIPAL*/}
        <section className="content">
            {/*AQUI VA EL LISTADO DE PELÍCULAS*/}

           <Listado listadoState={listadoState} setListadoState={setListadoState}/>

            
        </section>

        <aside className="lateral">
            <Buscador listadoState={listadoState} setListadoState={setListadoState}/>
           <Crear setListadoState={setListadoState}/>

        </aside>

          {/*BARRA INFERIOR DE NAVEGACIÓN O PIÉ DE PÁGINA*/}  
        <footer className="footer">
            &copy; Máster en Javascript ES12 y TypeScript - <a href="https://alexantonio29.github.io/PapeleriaBelen//#">PapeleriaBelen</a>

        </footer>

    </div>
  );
}

export default App;
