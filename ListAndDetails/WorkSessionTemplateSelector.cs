using System.Windows;
using System.Windows.Controls;

namespace ListAndDetails
{
    public class WorkSessionTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WorkTemplate { get; set; }
        public DataTemplate BreakTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var workSessionVm = (WorkSessionVm) item;

            if (workSessionVm.WorkSessionType == WorkSessionType.Break)
                return BreakTemplate;

            return WorkTemplate;
        }
    }
}
