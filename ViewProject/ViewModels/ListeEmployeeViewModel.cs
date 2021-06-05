using BusinessLayer;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewProject.Mock;
using ViewProject.ViewModels.Common;

namespace ViewProject.ViewModels
{
    public class ListeEmployeeViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailEmployeeViewModel> _Employees = null;
        private DetailEmployeeViewModel _selectedEmployee;

        #endregion

        #region Constructeurs

        public ListeEmployeeViewModel()
        {
            _Employees = new ObservableCollection<DetailEmployeeViewModel>();
            foreach (Employee e in BusinessManager.Instance.GetAllEmployee())
            {
                _Employees.Add(new DetailEmployeeViewModel(e));
            }

            if (_Employees != null && _Employees.Count > 0)
                _selectedEmployee = _Employees.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        public ObservableCollection<DetailEmployeeViewModel> Employees
        {
            get { return _Employees; }
            set
            {
                _Employees = value;
                OnPropertyChanged("Employees");
            }
        }

        public DetailEmployeeViewModel SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }


        #endregion
    }
}
