// src/services/dropdownService.js

export const fetchAndStoreDropdowns = async () => {
  try {
    const response = await fetch(`https://localhost:7277/api/DropDown/getall`); 
    if (!response.ok) throw new Error('Network response was not ok');

    const data = await response.json();

    
    sessionStorage.setItem('dropdowns', JSON.stringify(data));

    return data;
  } catch (error) {
    console.error('Error fetching dropdowns:', error);
    return null;
  }
};
