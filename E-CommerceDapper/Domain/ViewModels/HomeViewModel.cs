using E_CommerceDapper.DataAccess.Entites;
using E_CommerceDapper.Domain.Commands;
using E_CommerceDapper.Domain.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.Domain.ViewModels
{
    public class HomeViewModel:BaseViewModel
    {
		private ObservableCollection<Product> allProducts;

		public ObservableCollection<Product> AllProducts
        {
			get { return allProducts; }
			set { allProducts = value; OnPropertyChanged(); }
		}

		private Product selectedProduct;

		public Product SelectedProduct
		{
			get { return selectedProduct; }
			set { selectedProduct = value; OnPropertyChanged(); }
		}
		public RelayCommand	SelectedCommand { get; set; }
		public HomeViewModel()
		{
			var productsFromDb = App.DB.ProductRepository.GetAll();
			AllProducts = new ObservableCollection<Product>(productsFromDb);

			SelectedProduct = new Product();


			SelectedCommand = new RelayCommand((o) =>
			{
				ProductInfoViewModel vm = new ProductInfoViewModel(SelectedProduct);
				ProductInfo view = new ProductInfo();
				view.DataContext = vm;

				view.Show();
			});
		}

	}
}
