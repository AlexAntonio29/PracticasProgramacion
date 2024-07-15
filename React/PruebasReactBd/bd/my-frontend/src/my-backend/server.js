// backend/server.js


const express = require('express');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const cors = require('cors');


const app = express();
app.use(bodyParser.json());
app.use(cors());

// Conectar a MongoDB
mongoose.connect('mongodb://localhost:27017/userdata', { useNewUrlParser: true, useUnifiedTopology: true });

const UserSchema = new mongoose.Schema({
  name: String,
  email: String
});

const User = mongoose.model('User', UserSchema);

app.post('/api/users', async (req, res) => {
  const user = new User(req.body);
  await user.save();
  res.send(user);
});

app.get('/api/users', async (req, res) => {
  const users = await User.find();
  res.send(users);
});

app.listen(3001, () => {
  console.log('Server is running on port 3001');
});
