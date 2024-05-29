//importar modulos de react/ dependencias
import React from 'react';

//funcion del componente
const Micomponente = () => {


    let usuario ={

        nombre: "Alexis",
        apellido: "Antonio",
        matricula: "230110376",
    };

    return  (

        <div className='Mi-Componente'>
         <h1>Pagina web de Alex</h1>

        <hr/>
        
<p>Datos personales de Alex</p>

<ul>

    <li><strong>{usuario.nombre}</strong></li>
    <li><strong>{usuario.apellido}</strong></li>
    <li><strong>{usuario.matricula}</strong></li>
</ul>

        </div>

       
       

        
    
    );
    
    
        
            
};
//Export
export default Micomponente;


