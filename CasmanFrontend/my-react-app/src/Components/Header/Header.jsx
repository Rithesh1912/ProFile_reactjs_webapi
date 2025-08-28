import React from 'react';
import { useNavigate } from 'react-router-dom';
import './Header.css';
import logo from '../../Assets/profileBarWb.GIF';

function Header() {
  const navigate = useNavigate();

  const currentDate = new Date().toLocaleDateString('en-GB', {
    day: '2-digit',
    month: 'long',
    year: 'numeric',
  });

  const tabs = [
    {
      title: 'Case Details',
      submenu: [
        'Search',
        'Conflict Search',
        'General',
        'Address Book',
        'Advisory Case Wizard',
        'Summary',
        'Practitioner',
        'Patient',
        'Advisory Progress',
        'Last Results',
        'Recent Cases',
        'Other Individuals Involved',
        'Decisions',
      ],
    },
    {
      title: 'Case Review',
      submenu: [
        'Awaiting Review',
        'Storage Request',
        'CRU Review',
        'CRU',
        'Diary',
        'Track File',
        'Retention Schedule',
        'Physical Items',
      ],
    },
    {
      title: 'Administration',
      submenu: [
        'Create Case',
        'Create Back',
        'Split Case',
        'Amalgamate',
        'Reallocate',
        'Reallocate Advisory Case',
        'Set Restrictions',
        'Non Member Speech',
        'Case Details Report',
        'Maintain Payee',
        'Reasons For missed KPI',
      ],
    },
    {
      title: 'Reserve',
      submenu: [
        'Indemnity Reserve',
        'File Strategy History',
        'High Value Riview',
        'Closing Summary',
        'Progress',
        'Key legal Dates',
        'Authorise',
        'History',
      ],
    },
    {
      title: 'Payment',
      submenu: [
        'Indemnity Payment',
        'Legal/Disb Payment',
        'Payment Recoveries',
        'MDU Expenses',
        'Authorise',
        'Totals',
        'Aggregate Totals',
        'Payment Breakdown History',
        'Financial Details Report',
        'Batch',
        'Transfer Legal Payments',
        'View By MDU Reference',
        'Batch Expense',
        'Batch Recovery',
      ],
    },
    {
      title: 'Instruction',
      submenu: ['Legal', 'Expert/CCA', 'Search Expert'],
    },
    {
      title: 'TimeSheet',
      submenu: ['Supervision'],
    },
    {
      title: 'Legal',
      submenu: ['Manage Case stages', 'Quaterly Reports Info'],
    },
    {
      title: 'Doctas',
      submenu: ['Reports', 'Panel Setup'],
    },
    {
      title: 'Records management',
      submenu: [],
    },
    {
      title: 'Pro-File Admin',
      submenu: [
        'Maintain Role',
        'Maintain User',
        'Search Results Field',
        'Staff authorisation',
        'Release Info',
      ],
    },
  ];

  const handleMenuClick = (item) => {
    // Navigation mapping
    if (item === 'Create Case') {
      navigate('/CreateCase');
    }
    if (item === 'Search') {
      navigate('/searchcasedetails');
    }
    if (item === 'General') {
      navigate('/General');
    }
    if( item === 'Practitioner'){
      navigate('/ViewPractioner');
    }
    if( item === 'Add Practitioner'){
      navigate('/AddPractioner');
    }
    if( item === 'Recent Cases'){
      navigate('/RecentCases');
    }
  };

  const renderSubmenu = (submenu) => {
    return submenu.map((item, idx) => {
      if (typeof item === 'string') {
        return (
          <div
            key={idx}
            className="dropdown-item"
            onClick={() => handleMenuClick(item)}
            style={{ cursor: 'pointer' }}
          >
            {item}
          </div>
        );
      } else if (typeof item === 'object') {
        // Nested submenu
        return (
          <div key={idx} className="dropdown-item nested">
            <span>{item.title}</span>
            <div className="dropdown nested-dropdown">
              {renderSubmenu(item.submenu)}
            </div>
          </div>
        );
      }
      return null;
    });
  };

  return (
    <div className="header-container">
      <div className="top-bar">
        <img src={logo} alt="profileBarwb Logo" className="logo" />

        <div className="date">{currentDate}</div>
        <div className="user">
          Welcome rithesh
          <br />
          rathanavel(Support)
        </div>
      </div>

      <div className="nav-tabs">
        {tabs.map((tab, index) => (
          <div key={index} className="tab-wrapper">
            <div className="tab">{tab.title}</div>
            {tab.submenu && tab.submenu.length > 0 && (
              <div className="dropdown">{renderSubmenu(tab.submenu)}</div>
            )}
          </div>
        ))}
      </div>
    </div>
  );
}

export default Header;
