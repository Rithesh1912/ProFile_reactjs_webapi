import React, { createContext, useContext, useEffect, useState } from "react";

const DropdownsContext = createContext();
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

  const CACHE_KEY = "/api/dropdowns";
  const CACHE_TTL = 60 * 60 * 1000; // 1 hour

  const fetchDropdowns = async () => {
    setLoading(true);
    setError(null);

    try {
      const cache = await caches.open("dropdowns-cache");

      // check if cached
      const cachedResponse = await cache.match(CACHE_KEY);
      if (cachedResponse) {
        const cachedData = await cachedResponse.json();

        // check expiry
        if (Date.now() < cachedData.expiry) {
          // ✅ serve from cache
          setDropdowns(cachedData.data);
          setLoading(false);
          return;
        } else {
          // expired → delete
          await cache.delete(CACHE_KEY);
        }
      }

      // fetch fresh
      const res = await fetch("https://localhost:7277/api/DropDown/getall");
      if (!res.ok) throw new Error("Failed to fetch dropdowns");

      const data = await res.json();
      setDropdowns(data);

      // store with expiry
      const payload = {
        data,
        expiry: Date.now() + CACHE_TTL,
      };

      await cache.put(
        CACHE_KEY,
        new Response(JSON.stringify(payload), {
          headers: { "Content-Type": "application/json" },
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
