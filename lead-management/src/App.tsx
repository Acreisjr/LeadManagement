import React, { useState } from "react";
import Navbar from "./components/Navbar/Navbar";
import InvitedLeads from "./pages/InvitedLeads/InvitedLeads";
import AcceptedLeads from "./pages/AcceptedLeads/AcceptedLeads";

const App: React.FC = () => {
  const [activeTab, setActiveTab] = useState("Invited");

  return (
    <div>
      <Navbar activeTab={activeTab} setActiveTab={setActiveTab} />
      {activeTab === "Invited" ? <InvitedLeads /> : <AcceptedLeads />}
    </div>
  );
};

export default App;
