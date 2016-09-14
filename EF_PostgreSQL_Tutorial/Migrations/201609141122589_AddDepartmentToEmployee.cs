namespace EF_PostgreSQL_Tutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Employees", "Department", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Employees", "Department");
        }
    }
}
