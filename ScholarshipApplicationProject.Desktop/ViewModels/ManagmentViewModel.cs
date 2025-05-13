using ScholarshipApplicationProject.Console.Models;
using ScholarshipApplicationProject.Console.Repos;
using System.Collections.ObjectModel;

namespace ScholarshipApplicationProject.Desktop.ViewModels
{
    public class ManagmentViewModel
    {
        private ScholarshipRepo _repo=new();

        public ObservableCollection<ScholarshipApplicant> Applicants =>
            new ObservableCollection<ScholarshipApplicant>(_repo.GetApplicants());
    }
}
