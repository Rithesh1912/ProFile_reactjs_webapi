import './App.css';
import Header from './Components/Header/Header';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import CaseSearch from './Components/CaseSearch/CaseSearch';
import CreateCase from './Components/CreateCase/CreateCase';
import  General  from './Components/General/General';
import ViewPractioner from './Components/Practioner/ViewPractioner';
import AddPractitioner from './Components/Practioner/AddPractioner';
import { CaseProvider } from './Components/ContextAPI/CaseContext';
import RecentCases from './Components/RecentCases/RecentCases';
import { DropdownsProvider } from './Components/ContextAPI/DropDownContext';
import Register from './Components/Staff/StaffRegister';
import Login from './Components/Staff/StaffLogin';    
import ViewPatient from './Patient/ViewPatient';
import AddPatient from './Patient/AddPatient';


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
      <DropdownsProvider>
      <CaseProvider>
      <Router>
        <Header />
     
        
        <Routes>
          <Route path="/" element={<Login/>} />
          <Route path='/Register' element={<Register/>} />
          <Route path="/searchcasedetails" element={<CaseSearch></CaseSearch>} />
          <Route path='/CreateCase' element={<CreateCase></CreateCase>}></Route>
          <Route path='/General' element={<General></General>}></Route>
          <Route path="*" element={<h2>404: Page Not Found</h2>} />
          <Route path='/ViewPractioner' element={<ViewPractioner></ViewPractioner>}></Route>
          <Route path='/AddPractioner' element={<AddPractitioner></AddPractitioner>}></Route>
          <Route path='/RecentCases' element={<RecentCases/>}></Route>
          <Route path='/ViewPatient' element={<ViewPatient></ViewPatient>}></Route>
          <Route path='/AddPatient' element={<AddPatient></AddPatient>}></Route>
          
        </Routes>
      </Router>
      </CaseProvider>
        </DropdownsProvider>

    </div>
  );
}

export default App;
