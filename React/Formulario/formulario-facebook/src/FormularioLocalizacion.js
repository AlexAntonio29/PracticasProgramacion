import React from 'react'
import "./Formulario.css"

export const FormularioLocalizacion = () => {


    const estados = [
        'Aguascalientes', 'Baja California', 'Baja California Sur', 'Campeche', 'Chiapas',
        'Chihuahua', 'Coahuila', 'Colima', 'Durango', 'Guanajuato', 'Guerrero', 'Hidalgo',
        'Jalisco', 'México', 'Michoacán', 'Morelos', 'Nayarit', 'Nuevo León', 'Oaxaca',
        'Puebla', 'Querétaro', 'Quintana Roo', 'San Luis Potosí', 'Sinaloa', 'Sonora',
        'Tabasco', 'Tamaulipas', 'Tlaxcala', 'Veracruz', 'Yucatán', 'Zacatecas'
      ];

  return (
    <div className='designFormulario'>

<select placeholder='Estado' className='input' >
    <option value='' disabled>Estado</option>
    {estados.map((estado, index) => (
          <option key={index} value={estado}>{estado}</option>
        ))}
    
</select>



<input placeholder='Ciudad' className='input' type='text'/>
<input placeholder='Codigo Postal' className='input' type='text'/>
<input placeholder='Colonia' className='input' type='text'/>
<input placeholder='Domicilio' className='input' type='text'/>
<input placeholder='Numero Exterior' className='input' type='text'/>


<button className='design_button'>Continuar</button>



    </div>
  )
}
