using System.Threading;
using System.Threading.Tasks;
using Light.SharedCore.DatabaseAccessAbstractions;

namespace Light.DatabaseAccess.EntityFrameworkCore.Tests.Contacts.DeleteAllContacts;

public interface IDeleteAllContactsSession : IAsyncSession
{
    Task DeleteAllContactsAsync(CancellationToken cancellationToken = default);
}