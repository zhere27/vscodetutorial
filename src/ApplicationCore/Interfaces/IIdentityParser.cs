using System.Security.Principal;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
