using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.ViewModels.Common;

namespace View.ViewModels
{
    public class DetailEmployeeViewModel : BaseViewModel
    {
        #region Variables

        private int _id;
        private string _nom;
        private RelayCommand _addOperation;

        #endregion

        #region Constructeurs

        public DetailEmployeeViewModel(Employee e)
        {
            _id = e.Id;
            _nom = e.Nom;
        }

        #endregion

        #region Data Bindings

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        #endregion

        #region Commandes

        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }

        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }

        #endregion
    }
}
