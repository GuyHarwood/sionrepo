using System.Collections.Generic;

namespace domain
{
	public interface IContactRepository
	{
		Contact Select(int contactId);
		IEnumerable<Contact> Select(ContactSelection selection);
	}
}