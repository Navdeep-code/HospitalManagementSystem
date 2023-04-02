namespace HospitalManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDoctorsAppointment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "DoctorLName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "DoctorLName", c => c.String());
        }
    }
}
