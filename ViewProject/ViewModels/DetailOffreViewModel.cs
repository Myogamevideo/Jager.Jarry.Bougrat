using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewProject.ViewModels.Common;

namespace ViewProject.ViewModels
{
    public class DetailOffreViewModel : BaseViewModel
    {
        #region Variables

        private int _id;
        private string _intitule;
        private DateTime _date;
        private float _salaire;
        private RelayCommand _addOperation;

        #endregion

        #region Constructeurs

        public DetailOffreViewModel(Offre e)
        {
            _id = e.Id;
            _intitule = e.Intitule;
            _date = e.Date;
            _salaire = e.Salaire;

        }

        #endregion

        #region Data Bindings

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Intitule
        {
            get { return _intitule; }
            set { _intitule = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public float Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
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
            ViewProject.Views.Operation operationWindow = new ViewProject.Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }

        #endregion
    }
}
