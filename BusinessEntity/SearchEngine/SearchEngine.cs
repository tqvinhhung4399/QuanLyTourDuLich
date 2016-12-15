﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    // Adapter Pattern
    public class SearchEngine<TEntity> : ISearchAble<TEntity>
        where TEntity : class
    {
        ISearchAble<TEntity> _engine;

        public SearchEngine()
        {
            _engine = getEngine();
        }

        public IEnumerable<TEntity> Search(string keyword)
        {
            return _engine.Search(keyword);
        }


        private ISearchAble<TEntity> getEngine()
        {
            if (typeof(TEntity) == typeof(DTO.Customer))
            {
                return new CustomerSearchEngine() as ISearchAble<TEntity>;
            }
            if (typeof(TEntity) == typeof(DTO.Tour))
            {
                return new TourSearchEngine() as ISearchAble<TEntity>;
            }
            if (typeof(TEntity) == typeof(DTO.TourGroup))
            {
                return new TourGroupSearchEngine() as ISearchAble<TEntity>;
            }
            return null;
        }
    }
}
