using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Views;
using Supermarker_mvp.Models;

namespace Supermarker_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;
        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent   += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectPayMode;
            this.view.SaveEvent   += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);//con esto se importa la base de datos
                                                                        //del dataviewgrid
            loadAllPayModeList();//esto para cargar esa base de datos

            this.view.Show();
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }
        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) 
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            //Se crea  un objeto de la clase PayModeModel y se asignan los datos de
            //las cajas de texto de la vista
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try 
            {
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit) 
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode Edited is Successfuly";
                }
                else 
                {
                    repository.Add(payMode);
                    view.Message = "PayMode Add is Successfuly";
                }
            }catch(Exception ex) 
            { 
                //Si ocurre una excepcion se configura IsSuccessfull en false
                //y la propiedad Message de la vista se asigna el menssage de la excepcion
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            view.IsSuccessful = true;
            loadAllPayModeList();
            CleanViewFields();
        }
        private void CleanViewFields() 
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            try 
            {
                //se recupera el objeto de la fila seleccionada del datagriedview
                var payMode = (PayModeModel) payModeBindingSource.Current;

                //se invoca el metodo Delete del repositoria pasandode el ID del Pay Mode
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode Deleted is Successfully";
                loadAllPayModeList();
            }catch(Exception ex) 
            {
                view.IsSuccessful = false;
                view.Message = "An Error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            //se obtiene el objeto del datagriedview que se ecuentra seleccionado
            var payMode = (PayModeModel)payModeBindingSource.Current;

            //se cambia el contenido de las cajas de texto por el objeto recuperado
            //del datagriedview
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            //se establece el modo con edicion
            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
