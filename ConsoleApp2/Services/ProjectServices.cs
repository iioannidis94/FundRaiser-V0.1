using ConsoleApp2.DbContexts;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class ProjectServices : IProjectServices
    {

        private readonly OurDbContext _ourDbContext;


        public ProjectServices(OurDbContext ourDbContext)
        {
            _ourDbContext = ourDbContext;
        }



        public void CreateProject()
        {
            var project = new Project(); // this will need a change for the final version

            _ourDbContext.Projects.Add(project);
            _ourDbContext.SaveChanges();
        }

        public void DeleteProject()
        {
            int projectId = 5; // this will need a change for the final version
            _ourDbContext.Projects

            _ourDbContext.SaveChanges();


        }

        public void ReadProject()
        {
            

            List<Project> projects = _ourDbContext.Projects.ToList();

            projects.ForEach(project => 
                { Console.WriteLine($" project.Id = {project.Id}"); });  // this will need a change for the final version

        }

        public void UpdateProject()
        {
            throw new NotImplementedException();
        }
    }
}
