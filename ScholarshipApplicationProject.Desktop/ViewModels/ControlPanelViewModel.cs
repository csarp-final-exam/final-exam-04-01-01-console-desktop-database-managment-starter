using ScholarshipApplicationProject.Console.Repos;

namespace ScholarshipApplicationProject.Desktop.ViewModels
{
    public class ControlPanelViewModel
    {
        private ScholarshipRepo _repo = new();
        public string NumberOfScolarship => $"{_repo.GetNumberOfScholarship()} fő";
    }
}
