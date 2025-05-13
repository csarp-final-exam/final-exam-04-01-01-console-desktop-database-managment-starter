using ScholarshipApplicationProject.Console.DbModels;
using ScholarshipApplicationProject.Console.Models;

namespace ScholarshipApplicationProject.Console.Repos
{
    public class ScholarshipRepo
    {
        private readonly ScholarshipContext _context= new ScholarshipContext();

        public int GetNumberOfScholarship()
        {
            return _context.Scholarships.Count();
        }

        public List<ScholarshipApplicant> GetApplicants()
        {
            return _context.Scholarships.ToList();
        }

    }
}
