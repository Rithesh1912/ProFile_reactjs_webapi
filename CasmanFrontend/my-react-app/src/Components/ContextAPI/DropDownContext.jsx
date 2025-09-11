import React, { createContext, useContext, useEffect, useState } from "react";

// create context
const DropdownsContext = createContext();

// custom hook (for easy use in components)
export const useDropdowns = () => useContext(DropdownsContext);

export const DropdownsProvider = ({ children }) => {
    const [dropdowns, setDropdowns] = useState({
        specialties: [],
        liabilities: [],
        caseTypes: [],
        statuses: [],
        departments: [],
        categories: [],
        practices: [],
        classifications: [],
        staff: [],
        countries: [],
        indemnifiers: [],
    });
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    // fetch + cache (using Cache Storage API)
    const fetchDropdowns = async () => {
        setLoading(true);
        setError(null);

        try {
            // open cache storage
            const cache = await caches.open("dropdowns-cache");

            // check if data already cached
            //const cachedResponse = await cache.match("/api/dropdowns");
            const cached = await caches.match("/api/dropdowns");
            if (cached) {
                
                //console.log("Serving dropdowns from cache");
                const jsonData = await cached.json();
                setDropdowns(jsonData);
                return;
            }
            //console.log(" Fetching dropdowns from API");


            // otherwise fetch from API
            const res = await fetch("https://localhost:7277/api/DropDown/getall");
            if (!res.ok) throw new Error("Failed to fetch dropdowns");

            const data = await res.json();
            setDropdowns(data);
            const jsonData = JSON.stringify(data);
            // save response into cache
            await cache.put(
                "/api/dropdowns",
                new Response(JSON.stringify(data), {
                    headers: { "Content-Type": "application/json" },
                    "Content-Length": String(jsonData.length),
                })
            );
        } catch (err) {
            setError(err.message);
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        fetchDropdowns();
    }, []);

    return (
        <DropdownsContext.Provider
            value={{ dropdowns, loading, error, reload: fetchDropdowns }}
        >
            {children}
        </DropdownsContext.Provider>
    );
};
