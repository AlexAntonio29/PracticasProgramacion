import logo from './logo.svg';
import './App.css';
import { BaseCalculator } from './BaseCalculator';


function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />


      <BaseCalculator/>
      
      </header>
    </div>
  );
}

export default App;
