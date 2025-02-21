import React from "react";
import LeadCard from "../LeadCard/LeadCard";
import "./LeadList.css";

interface LeadListProps {
    leads: any[];
    onAccept?: (id: number) => void;
    onDecline?: (id: number) => void;
}

const LeadList: React.FC<LeadListProps> = ({ leads, onAccept, onDecline }) => {
    return (
        <div className="lead-list">
            {leads.map((lead) => (
                <LeadCard
                    key={lead.id}
                    lead={lead}
                    onAccept={onAccept ? () => onAccept(lead.id) : undefined}
                    onDecline={onDecline ? () => onDecline(lead.id) : undefined}
                />
            ))}
        </div>
    );
};

export default LeadList;
