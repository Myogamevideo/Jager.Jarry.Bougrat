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
    public class ListeOffreViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailOffreViewModel> _Offres = null;
        private DetailOffreViewModel _selectedOffre;

        #endregion

        #region Constructeurs

        public ListeOffreViewModel()
        {
            _Offres = new ObservableCollection<DetailOffreViewModel>();
            foreach (Offre e in BusinessManager.Instance.GetAllOffre())
            {
                _Offres.Add(new DetailOffreViewModel(e));
            }

            if (_Offres != null && _Offres.Count > 0)
                _selectedOffre = _Offres.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        public ObservableCollection<DetailOffreViewModel> Offres
        {
            get { return _Offres; }
            set
            {
                _Offres = value;
                OnPropertyChanged("Offres");
            }
        }

        public DetailOffreViewModel SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }


        #endregion
    }
}
