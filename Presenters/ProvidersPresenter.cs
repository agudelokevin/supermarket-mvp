using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
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
            this.view.DeleteEvent += DelectSelectProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);
            LoadAllProvidersList();
            this.view.Show();
        }

        private void LoadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
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
                    view.Message = "Providers edited successfuly";
                }
                else
                {
                    repository.Add(providers);
                    view.Message = "Providers added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllProvidersList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                //si ocurre una excepcion se configura Issuccesful en falso 
                //la propiedad message de la vista se asigna el mensaje de exception
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProvidersId = "0";
            view.ProvidersName = "";
            view.ProvidersObservation = "";
        }

        private void DelectSelectProviders(object? sender, EventArgs e)
        {
            try
            {//se recupera el objeto de la fila seleccionada
                var providers = (ProvidersModel)providersBindingSource.Current;

                repository.Delete(providers.Id);
                view.IsSuccessful = true;
                view.Message = "Providers deleted successfully";
                LoadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete providers";

            }
        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            //obtiene el objeto del datagridview 
            var providers = (ProvidersModel)providersBindingSource.Current;

            //se cambia el contenido de la caja de texto por el objeto recuperado
            view.ProvidersId = providers.Id.ToString();
            view.ProvidersName = providers.Name;
            view.ProvidersObservation = providers.Observation;

            //modo edicion
            view.IsEdit = true;
        }

        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
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
    }
}
