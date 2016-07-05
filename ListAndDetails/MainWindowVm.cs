using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDetails
{
    public class MainWindowVm
    {
        public ObservableCollection<PersonVm> People { get; set; } = new ObservableCollection<PersonVm>();
        public PersonVm SelectedPerson { get; set; }

        public MainWindowVm()
        {
            PopulatePeople();
        }

        private void PopulatePeople()
        {
            People.Add(new PersonVm("Maverik", "Real OG"));
            People.Add(new PersonVm("Johan", "Wizard"));
            People.Add(new PersonVm("Julien", "Apprentice"));
            People.Add(new PersonVm("C4u", "Pupil"));
            People.Add(new PersonVm("Alex", "New Hire"));
            People.Add(new PersonVm("Lynn", "Big Jerk"));
        }
    }
}
