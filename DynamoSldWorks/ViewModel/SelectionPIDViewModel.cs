using DynamoSldWorks.Model;
using Microsoft.Practices.Prism.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xarial.XCad;

namespace DynamoSldWorks.View
{
    public class SelectionPIDViewModel : NotificationObject
    {
        private readonly IXApplication _application;
        private ObservableCollection<SelectionPID> _selectionPIDs;
        private SelectionPID _selectedPIDItem;

        public SelectionPIDViewModel(ICollection<SelectionPID> pids,IXApplication application)
        {
            SelectionPIDs = new ObservableCollection<SelectionPID>(pids);
            _application = application;
        }

        public ObservableCollection<SelectionPID> SelectionPIDs
        {
            get => _selectionPIDs; set
            {
                _selectionPIDs=value;
                RaisePropertyChanged();
            }
        }

        public SelectionPID SelectedPIDItem { get => _selectedPIDItem; set {
                _selectedPIDItem = value;
                RaisePropertyChanged();
            } }

        public void DoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
