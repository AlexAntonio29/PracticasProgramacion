import React, { useEffect, useState } from 'react'

export const AjaxComponent = () => {

    
    const [usuarios, setUsuarios] = useState([]);
    const [cargando, setCargando] = useState(true);
    const [errores, setErrores] = useState("");

    //Generico o Básico
    const getUsuarioEstatico=()=>{
        setUsuarios([
                {
      "id": 1,
      "email": "michael.lawson@reqres.in",
      "first_name": "Michael",
      "last_name": "Lawson",
      "avatar": "https://reqres.in/img/faces/7-image.jpg"
    },
    {
      "id": 2,
      "email": "lindsay.ferguson@reqres.in",
      "first_name": "Lindsay",
      "last_name": "Ferguson",
      "avatar": "https://reqres.in/img/faces/8-image.jpg"
    },
    {
      "id": 3,
      "email": "tobias.funke@reqres.in",
      "first_name": "Tobias",
      "last_name": "Funke",
      "avatar": "https://reqres.in/img/faces/9-image.jpg"
    }
        ]);
    }


   


    const getUsuarioAjaxpms=()=>{

   fetch("https://reqres.in/api/users?page=2",{
headers:{
    "x-api-key": "reqres-free-v1"
}
   }) 
  .then(respuesta => respuesta.json())
  .then(
    resultado_final => {
      setUsuarios(resultado_final.data);
    },
    error => {
      console.log(error);
    
    }
  );
    }


    const getUsuariosAjaxAW= ()=>{

           

 setTimeout(async()=>{
 try{
        const peticion = await fetch("https://reqres.in/api/users?page=2",{
headers:{
    "x-api-key": "reqres-free-v1"
}
   });


   const {data} = await peticion.json();

   console.log(data);
   setUsuarios(data);
   setCargando(false);
}catch (error){

                console.log("ERROR FATAL ALEXIS "+error.message);
                  setErrores(error.message);

            }

        },2000);
            
       
    }


     useEffect(()=>{
        //getUsuarioEstatico();
       //getUsuarioAjaxpms();
       getUsuariosAjaxAW();
    },[]);

    //cuando esta cargando

//AQUI VAN LOS RETURNS------------------------------------------------
     if(cargando ==true){
 return(
        <div className='cargando'>

            Cargando...
        </div>

    );
    }


    else if(cargando ==false && errores === ""){
            //cuando se carga todo sin problemas
  return (
    <div>
        
        <h1>Listado Ajax Vía Components</h1>


        <ol className='usuarios'>

            {
                usuarios.map( usuarios =>{
                   
                    return <li style={{background:'green', borderRadius:"10px", margin:"5px", justifyContent:"center",alignContent:"center", display:"grid", gridTemplateColumns:"50% auto"}} key={usuarios.id}> 
                    <img src={usuarios.avatar} style={{borderRadius:"10px"}} />
                    {usuarios.first_name } {usuarios.last_name}</li>
                    
                })
            }

        </ol>
    </div>
  )

    }

    else if(errores!== ""){//SI DETECTA ERROR...
        return(

            <div>

                <h1>SE HA GENERADO UN ERROR AL CARGAR DATOS: {errores}</h1>
            </div>
        );
    }

   





   


}
