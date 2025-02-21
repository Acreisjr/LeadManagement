import React from "react";
import "./Navbar.css";

interface NavbarProps {
    activeTab: string;
    setActiveTab: (tab: string) => void;
}

const Navbar: React.FC<NavbarProps> = ({ activeTab, setActiveTab }) => {
    return (
        <nav className="navbar">
            <div className="navbar-container">
                <ul className="nav-links">
                    <li>
                        <button
                            className={activeTab === "Invited" ? "active" : ""}
                            onClick={() => setActiveTab("Invited")}
                        >
                            Invited
                        </button>
                    </li>
                    <li>
                        <button
                            className={activeTab === "Accepted" ? "active" : ""}
                            onClick={() => setActiveTab("Accepted")}
                        >
                            Accepted
                        </button>
                    </li>
                </ul>
            </div>
        </nav>
    );
};

export default Navbar;
