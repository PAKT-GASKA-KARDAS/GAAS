import { useState, useEffect } from "react";

interface Visit {
  id: string;
  dateStart: Date;
  dateEnd: Date;
  userId: string;
}

const useFetchVisitData = (
  userId: string
): [Visit[], boolean, Error | null] => {
  const [visitData, setVisitData] = useState<Visit[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [error, setError] = useState<Error | null>(null);

  useEffect(() => {
    const fetchVisitData = async (userId: string) => {
      setIsLoading(true);
      try {
        const response = await fetch(
          `http://localhost:5142/api/visits/${userId}`
        );
        const data = await response.json();
        setVisitData(data);
      } catch (error) {
        setError(error as Error);
      } finally {
        setIsLoading(false);
      }
    };
    fetchVisitData(userId);
  }, [userId]);

  return [visitData, isLoading, error];
};

export default useFetchVisitData;
