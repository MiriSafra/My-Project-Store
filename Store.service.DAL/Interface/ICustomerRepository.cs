﻿using StoreModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.service.DAL
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        void Add(Customer customer);
    }
}
