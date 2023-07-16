import { useState, useEffect } from "react";

interface Client {
  FirstName: string;
  LastName: string;
  Height: number;
  Weight: number;
}

const useFetchClientData = (
  userId: string
): [Client[], boolean, Error | null] => {
  const [clientData, setClientData] = useState<Client[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [error, setError] = useState<Error | null>(null);

  useEffect(() => {
    const fetchClientData = async (userId: string) => {
      setIsLoading(true);
      try {
        const response = await fetch(
          `http://localhost:5142/api/users/${userId}`
        );
        const data = await response.json();
        setClientData(data);
      } catch (error) {
        setError(error as Error);
      } finally {
        setIsLoading(false);
      }
    };
    fetchClientData(userId);
  }, [userId]);

  return [clientData, isLoading, error];
};

export default useFetchClientData;
