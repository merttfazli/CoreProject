﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();//Db de değişikleri kaydetmek için
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);// id ye göre arama işlemi

        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();// herşeyi listelemek için kullanılır.
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
