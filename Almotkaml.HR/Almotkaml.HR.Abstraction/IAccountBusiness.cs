using Almotkaml.Business;
using Almotkaml.HR.Models;

namespace Almotkaml.HR.Abstraction
{
    public interface IAccountBusiness : IDefaultAccount<LoginModel, ProfileModel, NotificationModel>
    {
    }
}