using E_CommerceDapper.DataAccess.Entites;
using E_CommerceDapper.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.Domain.ViewModels
{
    public class OrderViewModel:BaseViewModel
    {
		private OrderDetails order;

		public OrderDetails Order
        {
			get { return order; }
			set { order = value; OnPropertyChanged(); }
		}

		public RelayCommand	SubmitCommand { get; set; }
		public OrderViewModel(Product product)
		{
			Order = new OrderDetails();
			Order.UnitPrice = product.UnitPrice;
			Order.ProductId = product.ProductID;
			SubmitCommand = new RelayCommand((o) =>
			{
				//App.DB.OrderDetailsRepository.Add(Order);
				App.DB.OrderDetailsRepository.Add(order);
			});
		}

	}
}
