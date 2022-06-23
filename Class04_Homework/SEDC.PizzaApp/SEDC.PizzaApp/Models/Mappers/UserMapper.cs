using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel ToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber
            };
        }
    }
}
