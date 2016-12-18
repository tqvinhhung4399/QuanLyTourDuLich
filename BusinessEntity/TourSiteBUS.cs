﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BusinessEntity
{
    public class TourSiteBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();

        // ??
        public TourSite getCustomerById(int id)
        {
            return _unitOfWork.TourSiteRepository.GetByID(id);
        }

        public IEnumerable<TourSite> getEntries()
        {
            return _unitOfWork.TourSiteRepository.GetAll();
        }

        public void add(TourSite toursite)
        {
            _unitOfWork.TourSiteRepository.Insert(toursite);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourSiteRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourSiteRepository.Exists(key);
        }

        public void update(TourSite toursite)
        {
            _unitOfWork.TourSiteRepository.Update(toursite);
            _unitOfWork.Save();
        }
    }
}
