import './App.css';
import Header from './Components/Header/Header';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import CaseSearch from './Components/CaseSearch/CaseSearch';
import CreateCase from './Components/CreateCase/CreateCase';
import  General  from './Components/General/General';
import CaseHeader from './Components/CaseHeader/CaseHeader';


function App() {
  return (
    <div className="App">
      
      <Router>
        <Header />
        <CaseHeader/>
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
