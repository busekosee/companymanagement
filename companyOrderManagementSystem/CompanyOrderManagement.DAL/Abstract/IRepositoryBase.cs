﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderManagement.DAL.Abstract
{
    public interface IRepositoryBase<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetList();
        T GetById(int id);
        
    }
}
