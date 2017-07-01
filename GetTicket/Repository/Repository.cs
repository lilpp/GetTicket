using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetTicket.Models;
using GetTicket.DAL;
using GetTicket.ViewModel;
using Microsoft.AspNet.Identity;

namespace GetTicket.Repository
{
    public class Repository
    {
        DBContext _db = new DBContext();
        public void AddEventToDB(EventCreateViewModel viewModel, string userId)
        {
            var model = new EventsModel {
            ID = viewModel.ID,
            Name= viewModel.Name,
            StartDate = viewModel.StartDate,
            EndDate = viewModel.EndDate,
            PurcheEnd  = viewModel.PurcheEnd,
            Description = viewModel.Description,
            OwnerID = userId,
            LogoImgUrl = viewModel.LogoImgUrl
            };

            _db.EventModels.Add(model);
            _db.SaveChanges();
        }
    }
}