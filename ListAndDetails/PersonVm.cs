using System;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace ListAndDetails
{
    [ImplementPropertyChanged]
    public class PersonVm
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Salary { get; set; } = Convert.ToDecimal(Globals.Random.NextDouble() * 100000).ToString("C0");
        public string DateOfBirth { get; set; } = DateTime.UtcNow.AddDays(Globals.Random.Next(90)).ToShortDateString();

        public DateTime SelectedDate { get; set; }

        public ObservableCollection<WorkSessionVm> WorkSessions { get; set; } = new ObservableCollection<WorkSessionVm>();

        public PersonVm(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void OnSelectedDateChanged()
        {
            WorkSessions.Clear();

            WorkSessions.Add(new WorkSessionVm("12:00 AM", "12:00 PM", WorkSessionType.Work));
            WorkSessions.Add(new WorkSessionVm("12:00 PM", "1:00 PM", WorkSessionType.Break));
            WorkSessions.Add(new WorkSessionVm("1:00 PM", "5:00 PM", WorkSessionType.Work));
        }
    }
}
