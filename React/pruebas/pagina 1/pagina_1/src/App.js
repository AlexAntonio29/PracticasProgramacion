import logo from './logo.svg';
import './App.css';
import { Cabecera } from './Cabecera';
import { Nav } from './Nav';
import {Content} from './Content';
import { Footer } from './Footer';
import { Aside } from './Aside';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />

       <div id="Principal"> <h1>Menu de id </h1></div>
       <div id='grid_layout'> 
          <div id='design_head'>
          <Cabecera/>
          </div>

          <div id='design_nav'>
          <Nav/>
          </div>
          <div id="design_content">
          <Content/></div>
        
          <div id='design_aside'>
          <Aside/>
          </div>
       
          <div id= "design_footer"><Footer/></div>

        </div>
      </header>

    
    </div>
  );
}

export default App;



