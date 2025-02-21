const API_URL = "http://localhost:7139/api/Lead";

export const getInvitedLeads = async () => {
    console.log(`${API_URL}/invited`)
    const response = await fetch(`${API_URL}/invited`);
    console.log(response)
    return response.json();
};

export const getAcceptedLeads = async () => {
    const response = await fetch(`${API_URL}/accepted`);
    return response.json();
};

export const acceptLead = async (id: number) => {
    await fetch(`${API_URL}/${id}/accept`, { method: "POST" });
};

export const declineLead = async (id: number) => {
    await fetch(`${API_URL}/${id}/decline`, { method: "POST" });
};
