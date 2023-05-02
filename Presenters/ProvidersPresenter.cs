using Supermarker_mvp.Models;
using Supermarker_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_mvp.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;
        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSelectProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);//con esto se importa la base de datos
                                                                          //del dataviewgrid
            loadAllProvidersList();//esto para cargar esa base de datos

            this.view.Show();
        }
        private void loadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }
        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            //Se crea  un objeto de la clase PayModeModel y se asignan los datos de
            //las cajas de texto de la vista
            var providers = new ProvidersModel();
            providers.Id = Convert.ToInt32(view.ProvidersId);
            providers.Name = view.ProvidersName;
            providers.Observation = view.ProvidersObservation;

            try
            {
                new Common.ModelDataValidation().Validate(providers);
                if (view.IsEdit)
                {
                    repository.Edit(providers);
                    view.Message = "Providers Edited is Successfuly";
                }
                else
                {
                    repository.Add(providers);
                    view.Message = "Providers Add is Successfuly";
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
            loadAllProvidersList();
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProvidersId = "0";
            view.ProvidersName = "";
            view.ProvidersObservation = "";
        }

        private void DeleteSelectProviders(object? sender, EventArgs e)
        {
            try
            {
                //se recupera el objeto de la fila seleccionada del datagriedview
                var providers = (ProvidersModel)providersBindingSource.Current;

                //se invoca el metodo Delete del repositoria pasandode el ID del Pay Mode
                repository.Delete(providers.Id);
                view.IsSuccessful = true;
                view.Message = "Providers Deleted is Successfully";
                loadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error ocurred, could not delete providers";
            }
        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            //se obtiene el objeto del datagriedview que se ecuentra seleccionado
            var providers = (ProvidersModel)providersBindingSource.Current;

            //se cambia el contenido de las cajas de texto por el objeto recuperado
            //del datagriedview
            view.ProvidersId = providers.Id.ToString();
            view.ProvidersName = providers.Name;
            view.ProvidersObservation = providers.Observation;

            //se establece el modo con edicion
            view.IsEdit = true;
        }

        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
