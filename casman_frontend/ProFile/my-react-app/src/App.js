import './App.css';
import Header from './Components/Header/Header';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import CaseSearch from './Components/CaseSearch/CaseSearch';
import CreateCase from './Components/CreateCase/CreateCase';
import  General  from './Components/General/General';


function App() {
  return (
    <div className="App">
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}

      <Router>
        <Header />
        <Routes>
          <Route path="/" element={<Navigate to="/searchcasedetails" replace />} />
          <Route path="/searchcasedetails" element={<CaseSearch></CaseSearch>} />
          <Route path='/CreateCase' element={<CreateCase></CreateCase>}></Route>
          <Route path='/General' element={<General></General>}></Route>
        </Routes>
      </Router>


    </div>
  );
}

export default App;
