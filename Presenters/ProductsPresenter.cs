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
            this.view.DeleteEvent += DeleteSelectProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);//con esto se importa la base de datos
                                                                        //del dataviewgrid
            loadAllProductsList();//esto para cargar esa base de datos

            this.view.Show();
        }

        private void loadAllProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
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

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            //Se crea  un objeto de la clase PayModeModel y se asignan los datos de
            //las cajas de texto de la vista
            var products = new ProductsModel();
            products.Id = Convert.ToInt32(view.ProductsId);
            products.Name = view.ProductsName;
            products.Observation = view.ProductsObservation;

            try
            {
                new Common.ModelDataValidation().Validate(products);
                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Products Edited is Successfuly";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Products Add is Successfuly";
                }
            }
            catch (Exception ex)
            {
                //Si ocurre una excepcion se configura IsSuccessfull en false
                //y la propiedad Message de la vista se asigna el menssage de la excepcion
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            view.IsSuccessful = true;
            loadAllProductsList();
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsObservation = "";
        }

        private void DeleteSelectProducts(object? sender, EventArgs e)
        {
            try
            {
                //se recupera el objeto de la fila seleccionada del datagriedview
                var products = (ProductsModel)productsBindingSource.Current;

                //se invoca el metodo Delete del repositoria pasandode el ID del Pay Mode
                repository.Delete(products.Id);
                view.IsSuccessful = true;
                view.Message = "Products Deleted is Successfully";
                loadAllProductsList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error ocurred, could not delete products";
            }
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            //se obtiene el objeto del datagriedview que se ecuentra seleccionado
            var products = (ProductsModel)productsBindingSource.Current;

            //se cambia el contenido de las cajas de texto por el objeto recuperado
            //del datagriedview
            view.ProductsId = products.Id.ToString();
            view.ProductsName = products.Name;
            view.ProductsObservation = products.Observation;

            //se establece el modo con edicion
            view.IsEdit = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
