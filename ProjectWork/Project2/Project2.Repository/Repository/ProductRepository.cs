﻿
using Project2.DBContext.ProjectDBContext;
using Project2.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Repository.Repository
{
    public class ProductRepository
    {
        Project2DBContext db = new Project2DBContext();
        public bool Add(Product product)
        {
            int isExecuted = 0;

            db.Products.Add(product);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public bool Delete(Product product)
        {
            int isExecuted = 0;
            Product aProduct = db.Products.FirstOrDefault(c => c.ID == product.ID);

            db.Products.Remove(aProduct);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }
        public bool Update(Product product)
        {
            int isExecuted = 0;

            db.Entry(product).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }
        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public Product GetByID(Product product)
        {
            Product aProduct = db.Products.FirstOrDefault(c => c.ID == product.ID);
            return aProduct;
        }
    }
}
