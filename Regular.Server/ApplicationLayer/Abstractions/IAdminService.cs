using Regular.Server.Models;

namespace Regular.Server.ApplicationLayer.Abstractions
{
    public interface IAdminService
    {
        RegisterViewModel GetAdminViewModel();
        void Register(RegisterInputModel input);
    }
}