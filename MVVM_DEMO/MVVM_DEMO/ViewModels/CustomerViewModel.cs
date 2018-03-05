namespace MVVM_DEMO.ViewModels
{
    using System;
    using System.Diagnostics;
    using MVVM_DEMO.Models;
    using System.Windows.Input;
    using MVVM_DEMO.Commands;
    using MVVM_DEMO.Views;

    internal class CustomerViewModel
    {
        private Customer customer;
        private CustomerInfoViewModel childViewModel;

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class
        /// </summary>
        public CustomerViewModel()
        {
            customer = new Customer("David");
            childViewModel = new CustomerInfoViewModel() {Info = "Instantiated in CustomerViewModel() ctor."};
            UpdateCommand = new UpdateCustomerCommand(this);
        }
        /// <summary>
        /// Gets or sets a System.Boolean value indicating whether the Customer can be updated.
        /// </summary>
        public bool CanUpdate
        {
            get
            {
                if (Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }


        public Customer Customer
        {
            get
            {
                return customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Svae changes made to the Customer instance.
        /// </summary>
        public void SaveChanges()
        {
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = childViewModel;

            //childViewModel.Info = Customer.Name + " was updated in the database";

            view.ShowDialog();
        }
    }
}
