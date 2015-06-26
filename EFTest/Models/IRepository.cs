﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> SelectAll();
        T SelectByID(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save();
    }
}
