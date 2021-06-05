using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewProject.ViewModels.Common;

namespace ViewProject.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Variables

        private ListeEmployeeViewModel _listeEmployeeViewModel = null;

        #endregion

        #region Constructeurs

        public HomeViewModel()
        {
            _listeEmployeeViewModel = new ListeEmployeeViewModel();
        }

        #endregion

        #region Data Bindings

        public ListeEmployeeViewModel ListeEmployeeViewModel
        {
            get { return _listeEmployeeViewModel; }
            set { _listeEmployeeViewModel = value; }
        }

        #endregion
    }
}
