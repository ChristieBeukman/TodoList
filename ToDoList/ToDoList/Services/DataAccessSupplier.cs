﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model;

namespace ToDoList.Services
{
    public class DataAccessSupplier : IDataAccessSupplier
    {
        ToDoDbEntities ctx;

        public DataAccessSupplier()
        {
            ctx = new ToDoDbEntities();
        }

        public void CreateSupplier()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Suppliier> GetSupplierDataAccess()
        {
            ObservableCollection<Suppliier> Suppliers = new ObservableCollection<Suppliier>();

            var Query = from a in ctx.Suppliiers
                        select a;

            foreach (var item in Query)
            {
                Suppliers.Add(item);
            }

            return Suppliers;
        }
    }
}
