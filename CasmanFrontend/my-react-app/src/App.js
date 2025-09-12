import './App.css';
import Header from './Components/Header/Header';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import CaseSearch from './Components/CaseSearch/CaseSearch';
import CreateCase from './Components/CreateCase/CreateCase';
import General from './Components/General/General';
import ViewPractioner from './Components/Practioner/ViewPractioner';
import AddPractitioner from './Components/Practioner/AddPractioner';
import { CaseProvider } from './Components/ContextAPI/CaseContext';
import RecentCases from './Components/RecentCases/RecentCases';
import { DropdownsProvider } from './Components/ContextAPI/DropDownContext';

import Register from './Components/Staff/StaffRegister';
import Login from './Components/Staff/StaffLogin';
import ViewPatient from './Patient/ViewPatient';
import AddPatient from './Patient/AddPatient';
import { AuthProvider } from './Components/ContextAPI/AuthContext';
import ProtectedRoute from './Components/Routing/ProtectedRoute';
import CaseHeader from './Components/CaseHeader/CaseHeader';
import ConflictSearch from './Components/CaseSearch/ConflictSearch';

function App() {
  return (
    <div className="App">
      <AuthProvider>
        <DropdownsProvider>
          <CaseProvider>
            <Router>
              <Header />
              <CaseHeader />
              <Routes>
                {/* Public routes */}
                <Route path="/" element={<Login />} />
                

                {/* Protected routes */}
                <Route
                  path="/searchcasedetails"
                  element={
                    <ProtectedRoute>
                      <CaseSearch />
                    </ProtectedRoute>
                  }
                />
                <Route
                  path="/ConflictSearch"
                  element={
                    <ProtectedRoute>
                      <ConflictSearch />
                    </ProtectedRoute>
                  }
                />
                <Route
                  path="/Register"
                  element={
                    <ProtectedRoute>
                      <Register />
                    </ProtectedRoute>
                  }
                />
                <Route
                  path="/CreateCase"
                  element={
                    <ProtectedRoute>
                      <CreateCase />
                    </ProtectedRoute>
                  }
                />
                <Route
                  path="/General"
                  element={
                    <ProtectedRoute>
                      <General />
                    </ProtectedRoute>
                  }
                />
                <Route
                  path="/ViewPractioner"
                  element={
                    <ProtectedRoute>
                      <ViewPractioner />
                    </ProtectedRoute>
                  }
                />
                <Route
                  path="/AddPractioner"
                  element={
                    <ProtectedRoute>
                      <AddPractitioner />
                    </ProtectedRoute>
                  }
                />
                <Route
                  path="/RecentCases"
                  element={
                    <ProtectedRoute>
                      <RecentCases />
                    </ProtectedRoute>
                  }
                />
                <Route path="*" element={<h2>404: Page Not Found</h2>} />
          <Route path='/ViewPatient' element={<ViewPatient></ViewPatient>}></Route>
          <Route path='/AddPatient' element={<AddPatient></AddPatient>}></Route>
          
              </Routes>
            </Router>
          </CaseProvider>
        </DropdownsProvider>
      </AuthProvider>
    </div>
  );
}

export default App;
