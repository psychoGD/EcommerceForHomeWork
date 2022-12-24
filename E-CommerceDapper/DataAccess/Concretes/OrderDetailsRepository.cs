using Dapper;
using E_CommerceDapper.DataAccess.Abstractions;
using E_CommerceDapper.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace E_CommerceDapper.DataAccess.Concretes
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private string ConnectionString { get; set; }
        public OrderDetailsRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }
        public void Add(OrderDetails data)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var query = @"
INSERT INTO [Order Details]([ProductId],[UnitPrice],[Quantity],[Discount]) 
VALUES(@ProductId,@UnitPrice,@Quantity,@Discount)
";
                var affectedRow = connection.Execute(query, new
                {
                    ProductId = data.ProductId,
                    UnitPrice = data.UnitPrice,
                    Quantity = data.Quantity,
                    Discount = data.Discount,
                });
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetails Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetails data)
        {
            throw new NotImplementedException();
        }
    }
}
