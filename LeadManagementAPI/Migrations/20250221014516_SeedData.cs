using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeadManagementAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        INSERT INTO Leads (FirstName, LastName, Suburb, Category, Description, Price, DateCreated, PhoneNumber, Email, Status) 
        VALUES 
        ('John', 'Doe', 'New York', 'Plumbing', 'Fix a broken pipe in the bathroom.', 150.00, GETDATE(), '123456789', 'john.doe@example.com', 'Invited'),
        
        ('Alice', 'Smith', 'Los Angeles', 'Painting', 'Paint the living room.', 250.00, GETDATE(), '987654321', 'alice.smith@example.com', 'Invited'),

        ('Bob', 'Johnson', 'Chicago', 'Electrical', 'Install new ceiling lights.', 350.00, GETDATE(), '567890123', 'bob.johnson@example.com', 'Accepted'),

        -- Novas entradas adicionadas:
        ('Emma', 'Williams', 'San Francisco', 'Carpentry', 'Build a custom bookshelf.', 400.00, GETDATE(), '234567890', 'emma.williams@example.com', 'Accepted'),

        ('Michael', 'Brown', 'Miami', 'Landscaping', 'Design and plant a garden.', 600.00, GETDATE(), '345678901', 'michael.brown@example.com', 'Invited'),

        ('Sophia', 'Miller', 'Boston', 'Cleaning', 'Deep clean a 3-bedroom apartment.', 200.00, GETDATE(), '456789012', 'sophia.miller@example.com', 'Invited'),

        ('Daniel', 'Garcia', 'Seattle', 'Roofing', 'Repair damaged roof shingles.', 750.00, GETDATE(), '567890123', 'daniel.garcia@example.com', 'Declined'),

        ('Olivia', 'Davis', 'Dallas', 'Plumbing', 'Replace a leaking kitchen faucet.', 180.00, GETDATE(), '678901234', 'olivia.davis@example.com', 'Invited');
    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        DELETE FROM Leads WHERE Email IN (
            'john.doe@example.com', 'alice.smith@example.com', 'bob.johnson@example.com',
            'emma.williams@example.com', 'michael.brown@example.com', 'sophia.miller@example.com',
            'daniel.garcia@example.com', 'olivia.davis@example.com'
        );
    ");
        }
    }
}
