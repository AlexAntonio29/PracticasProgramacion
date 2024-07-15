// src/UserData.js
import React, { useState, useEffect } from 'react';
import axios from 'axios';

function UserData() {

    
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [users, setUsers] = useState([]);

  const handleSave = async () => {
   
    await axios.post('http://localhost:3001/api/users', { name, email });
    alert('Datos guardados exitosamente!');
    fetchUsers(); // Actualiza la lista de usuarios
  };

  const fetchUsers = async () => {
    const response = await axios.get('http://localhost:3001/api/users');
    setUsers(response.data);
  }

  useEffect(() => {
    fetchUsers();
  }, []);

  return (
    <div>
      <h2>Guardar Datos del Usuario</h2>
      <div>
        <label>
          Nombre:
          <input
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
        </label>
      </div>
      <div>
        <label>
          Email:
          <input
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </label>
      </div>
      <button onClick={handleSave}>Guardar</button>
      <h2>Usuarios Guardados</h2>
      <ul>
        {users.map((user) => (
          <li key={user._id}>{user.name} - {user.email}</li>
        ))}
      </ul>
    </div>
  );
}

export default UserData;
