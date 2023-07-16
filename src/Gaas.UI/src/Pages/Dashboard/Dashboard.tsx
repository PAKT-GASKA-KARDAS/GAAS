import "./Dashboard.scss";
import useFetchClientData from "../../Hooks/ClientData";

const Dashboard = ({ userId }: { userId: string }) => {
  const [clientData, isLoading, error] = useFetchClientData(userId);

  if (isLoading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>Error: {error.message}</div>;
  }

  return (
    <div>
      <h2>
        {clientData[0].FirstName} {clientData[0].LastName}
      </h2>
      <p>Height: {clientData[0].Height}</p>
      <p>Weight: {clientData[0].Weight}</p>
    </div>
  );
};

export default Dashboard;
