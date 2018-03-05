namespace MVVM_DEMO.Commands
{
    using System;
    using System.Windows.Input;
    using MVVM_DEMO.ViewModels;
    internal class UpdateCustomerCommand : ICommand
    {
        private CustomerViewModel viewModel;
        /// <summary>
        /// Initialize a new instance of the CustomerUpdateCommand class
        /// </summary>
        /// <param name="viewModel"></param>
        public UpdateCustomerCommand(CustomerViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

      
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return String.IsNullOrWhiteSpace(viewModel.Customer.Error);
        }

        public void Execute(object parameter)
        {
            viewModel.SaveChanges();
        }
    }
}
