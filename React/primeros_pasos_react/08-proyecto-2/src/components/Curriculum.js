import React from 'react'

export const Curriculum = () => {
  return (
    <div className='page'>
      <h1>Curriculum  :</h1>
      <h2>Programador - Desarrollador FreeLancer.</h2>

      <section className='services'>
        <article className='service'>
          <h2>Desarrollo Frontend con React.js</h2>
          <ul>
            <li>Páginas web interactivas y responsivas</li>
            <li>Buen manejo del estado y rutas con React Router.</li>
          </ul>
        </article>

        <article className='service'>
          <h2>Sistema Web con MERN Stack (MongoDB, Express, React, Node.js)</h2>
          <ul>
            <li>Desarrollo de formularios dinámicos y conexión con base de datos.</li>
            <li>Validaciones y almacenamiento de datos en tiempo real.</li>
            <li>Backend con Express y API RESTful funcional.</li>
          </ul>
        </article>

        <article className='service'>
          <h2>C# con Apache para análisis de métodos numéricos</h2>
          <ul>
            <li>Programas para resolver ecuaciones, matrices y más</li>
            <li>Orientado a estudiantes de ingeniería.</li>
          </ul>
        </article>

           <article className='service'>
          <h2>Aplicaciones Android (Java / XML)</h2>
          <ul>
            <li>Calculadoras científicas y financieras funcionales</li>
            <li>Aplicaciones con diseño limpio y optimizadas para móviles.</li>
          </ul>
        </article>

        <article className='service'>
          <h2>Sistema de Consultorio Médico (Java + SQLite)</h2>
          <ul>
            <li>Desarrollo completo de un sistema de gestión médica con base de datos local.</li>
            <li>Registro de pacientes, historial clínico, y gestión de citas.</li>
            <li>Interfaz amigable para escritorio</li>
          </ul>
        </article>

       
      </section>

    </div>
  )
}
