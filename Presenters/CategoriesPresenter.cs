using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;


            this.view.SearchEvent += SearchCategories;

            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DelectSelectCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildingSource(categoriesBindingSource);
            LoadAllCategoriesList();
            this.view.Show();
        }

        private void LoadAllCategoriesList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.Id = Convert.ToInt32(view.CategoriesId);
            categories.Name = view.CategoriesName;
            categories.Observation = view.CategoriesObservation;

            try
            {
                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Categories edited successfuly";
                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Categories added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCategoriesList();
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
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesObservation = "";
        }

        private void DelectSelectCategories(object? sender, EventArgs e)
        {
            try
            {//se recupera el objeto de la fila seleccionada
                var categories = (CategoriesModel)categoriesBindingSource.Current;

                repository.Delete(categories.Id);
                view.IsSuccessful = true;
                view.Message = "Categories deleted successfully";
                LoadAllCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete categories";

            }
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            //obtiene el objeto del datagridview 
            var categories = (CategoriesModel)categoriesBindingSource.Current;

            //se cambia el contenido de la caja de texto por el objeto recuperado
            view.CategoriesId = categories.Id.ToString();
            view.CategoriesName = categories.Name;
            view.CategoriesObservation = categories.Observation;

            //modo edicion
            view.IsEdit = true;
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }
    }
}
