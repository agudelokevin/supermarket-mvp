using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;


            this.view.SearchEvent += SearchPayMode;

            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DelectSelectPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);
            LoadAllProductList();
            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductName;
            product.Observation = view.ProductObservation;

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfuly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
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
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductObservation = "";
        }

        private void DelectSelectPayMode(object? sender, EventArgs e)
        {
            try
            {//se recupera el objeto de la fila seleccionada
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete product";

            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            //obtiene el objeto del datagridview 
            var product = (ProductModel)productBindingSource.Current;

            //se cambia el contenido de la caja de texto por el objeto recuperado
            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductObservation = product.Observation;

            //modo edicion
            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}

