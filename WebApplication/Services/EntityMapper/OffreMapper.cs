using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Services.EntityMapper
{
    public class OffreMapper : IEntityMapper<Offre, OffreViewModel>
    {
        public void Map(Offre entity, OffreViewModel viewModel)
        {
            viewModel.Id = entity.Id;
            viewModel.Intitule = entity.Intitule;
            viewModel.Responsible = entity.Responsible;
            viewModel.Salaire = entity.Salaire;
            viewModel.Date = entity.Date;
            viewModel.Description = entity.Description;
            StatutViewModel statutViewModel = new StatutViewModel() {
                Id = entity.Statut.Id,
                Label = entity.Statut.Label
            };
            viewModel.Statut = statutViewModel;
        }
    }
}