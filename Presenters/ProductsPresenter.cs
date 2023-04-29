using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Views;
using Supermarker_mvp.Models;

namespace Supermarker_mvp.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductsModel> productsList;

        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEdit;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);
            LoadAllProductsList();
            this.view.Show();
        }

        private void LoadAllProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);

            if (emptyValue == false) 
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else 
            {
                productsList = repository.GetAll();
            }
            productsBindingSource.DataSource = productsList;
        }
    }
}
