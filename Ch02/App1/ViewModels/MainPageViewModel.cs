using App1.Models;
using App1.Common;
namespace App1.ViewModels
{
    public class MainPageViewModel
    {
        private RelayCommand _UpdateRelayCommand;
        public Customer MyCustomer { get; set; }

        public MainPageViewModel()
        {
            MyCustomer = new Customer()
            {
                FirstName = "Bob",
                LastName = "Smith"
            };
        }
    }
}