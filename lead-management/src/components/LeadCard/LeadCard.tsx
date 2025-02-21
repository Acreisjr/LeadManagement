import React from "react";
import "./LeadCard.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faMapMarkerAlt, faBriefcase, faPhone, faEnvelope } from "@fortawesome/free-solid-svg-icons";

interface LeadProps {
    lead: {
        id: number;
        firstName: string;
        lastName: string;
        suburb: string;
        category: string;
        description: string;
        price: number;
        dateCreated: string;
        phoneNumber: string;
        email: string;
        status: "Invited" | "Accepted";
    };
    onAccept?: () => void;
    onDecline?: () => void;
}

const LeadCard: React.FC<LeadProps> = ({ lead, onAccept, onDecline }) => {
    const formattedDate = lead.dateCreated
        ? new Date(lead.dateCreated).toLocaleString("en-US", {
            weekday: "long",
            year: "numeric",
            month: "long",
            day: "numeric",
            hour: "2-digit",
            minute: "2-digit",
        })
        : "No Date Available";

    return (
        <div className="lead-card">
            <div className="lead-header">
                <div className="lead-avatar">{lead.firstName[0]}</div>
                <div className="lead-info">
                    <p><b>{lead.firstName} {lead.status === "Accepted" && lead.lastName}</b> </p>
                    <p className="lead-time">{formattedDate}</p>
                </div>
            </div>

            <div className="lead-details">
                <p><FontAwesomeIcon icon={faMapMarkerAlt} /> {lead.suburb}</p>
                <p><FontAwesomeIcon icon={faBriefcase} /> {lead.category}</p>
                <p>Job ID: {lead.id}</p>
                {lead.status === "Accepted" && (
                    <p className="lead-text"> {lead.price.toFixed(2)} Lead Invitation</p>)}
            </div>
            {lead.status === "Accepted" && (
                <div className="lead-contact">
                    <p><FontAwesomeIcon icon={faPhone} className="icon" /> <span className="contact-text">{lead.phoneNumber}</span></p>
                    <p><FontAwesomeIcon icon={faEnvelope} className="icon" /> <span className="contact-text">{lead.email}</span></p>
                </div>
            )}
            <div>
                <p className="lead-description">{lead.description}</p>
            </div>

            {lead.status !== "Accepted" && (
                <div className="lead-actions">
                    <button onClick={onAccept} className="accept-btn">Accept</button>
                    <button onClick={onDecline} className="decline-btn">Decline</button>
                    <p className="lead-text"><span className="lead-price">${lead.price.toFixed(2)} </span> Lead Invitation</p>
                </div>)}
        </div>
    );
};

export default LeadCard;
