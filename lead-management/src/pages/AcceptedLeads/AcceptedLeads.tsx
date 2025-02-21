import React, { useEffect, useState } from "react";
import LeadList from "../../components/LeadList/LeadList";
import { getAcceptedLeads } from "../../api/LeadService";
import "./AcceptedLeads.css";

const AcceptedLeads: React.FC = () => {
    const [leads, setLeads] = useState([]);

    useEffect(() => {
        loadLeads();
    }, []);

    const loadLeads = async () => {
        const data = await getAcceptedLeads();
        setLeads(data);
    };

    return (
        <div className="accepted-leads-container">
            <LeadList leads={leads} />
        </div>
    );
};

export default AcceptedLeads;
