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
        /// <summary>
        /// Lekérdezi az adatbázisból Userhez tartozó Eventeket.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>IndexViewModel Listát add vissza</returns>
        public List<EventsIndexViewModel> GetUserEvents(string userId)
        {
            try
            {
                var viewModelList = (from evn in _db.EventModels
                                     where userId == evn.OwnerID
                                     select new EventsIndexViewModel() {ID = evn.ID, Name=evn.Name, StartDate = evn.StartDate, EndDate = evn.EndDate}).ToList();

                return viewModelList;
            }
            catch (Exception exp)
            {
                throw;
            }
           
        }
        /// <summary>
        /// User áltál létrhezott event viewModeljét átalakitja modelé és menti db-ben
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="userId"></param>
        public void InsertOrUpdateUserEvent(EventCreateViewModel viewModel, string userId)
        {
            try
            {
                if (viewModel.ID != 0)
                {
                    var model = new EventsModel
                    {
                        ID = viewModel.ID,
                        Name = viewModel.Name,
                        StartDate = viewModel.StartDate,
                        EndDate = viewModel.EndDate,
                        PurcheEnd = viewModel.PurcheEnd,
                        Description = viewModel.Description,
                        OwnerID = userId,
                        LogoImgUrl = viewModel.LogoImgUrl
                    };

                    _db.EventModels.Add(model);
                    _db.SaveChanges();
                }

                else
                { 
                    var model = new EventsModel
                    {
                        Name = viewModel.Name,
                        StartDate = viewModel.StartDate,
                        EndDate = viewModel.EndDate,
                        PurcheEnd = viewModel.PurcheEnd,
                        Description = viewModel.Description,
                        OwnerID = userId,
                        LogoImgUrl = viewModel.LogoImgUrl
                    };

                    _db.EventModels.Add(model);
                    _db.SaveChanges();
                }
            }
            catch (Exception exp)
            {

                throw;
            }
        }
        /// <summary>
        /// Törli User egy esemenyét
        /// </summary>
        /// <param name="eventId"></param>
        public void DeleteUserEvent(int eventId)
        {
            try
            {
                var model = _db.EventModels.Find(eventId);
                _db.EventModels.Remove(model);
                _db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}