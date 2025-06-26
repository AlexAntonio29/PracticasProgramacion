import logo from './logo.svg';
import './App.css';
import { PruebaComponents } from './Componentes/PruebaComponents';
import { AjaxComponent } from './Componentes/AjaxComponent';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <PruebaComponents/>

        <AjaxComponent/>
      </header>
    </div>
  );
}

export default App;
