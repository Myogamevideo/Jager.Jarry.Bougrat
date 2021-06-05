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

        private ListeOffreViewModel _listeOffreViewModel = null;

        #endregion

        #region Constructeurs

        public HomeViewModel()
        {
            _listeOffreViewModel = new ListeOffreViewModel();
        }

        #endregion

        #region Data Bindings

        public ListeOffreViewModel ListeOffreViewModel
        {
            get { return _listeOffreViewModel; }
            set { _listeOffreViewModel = value; }
        }

        #endregion
    }
}
