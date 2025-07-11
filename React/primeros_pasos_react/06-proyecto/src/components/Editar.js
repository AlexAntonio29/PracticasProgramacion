import React from 'react'

export const Editar = () => {

    const titulo_componente="Editar Titulo";
  return (
    <div className='edit_form'>

        <h3 className='title'>{titulo_componente}</h3>
        <form>

            <input 
            type="text"
            placeholder='titulo'
            id='titulo'
            className='titulo_editado'
            name='titulo'
           
            />

            <textarea
            placeholder='descripcion'
            id='descripcion'
            name='descripcion'
            className='descripcion_editado'
            ></textarea>
            
            <input type='submit' value="Editar"/>


        </form>


    </div>
  )
}
