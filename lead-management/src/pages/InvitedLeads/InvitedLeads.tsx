import React, { useEffect, useState } from "react";
import LeadList from "../../components/LeadList/LeadList";
import { getInvitedLeads, acceptLead, declineLead } from "../../api/LeadService";
import "./InvitedLeads.css";

const InvitedLeads: React.FC = () => {
    const [leads, setLeads] = useState([]);

    useEffect(() => {
        loadLeads();
    }, []);

    const loadLeads = async () => {
        const data = await getInvitedLeads();
        setLeads(data);
    };

    const handleAccept = async (id: number) => {
        await acceptLead(id);
        loadLeads();
    };

    const handleDecline = async (id: number) => {
        await declineLead(id);
        loadLeads();
    };

    return (
        <div className="invited-leads-container">
            <LeadList leads={leads} onAccept={handleAccept} onDecline={handleDecline} />
        </div>
    );
};

export default InvitedLeads;
