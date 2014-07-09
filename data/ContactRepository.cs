using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using domain;

namespace data
{
	public class ContactRepository : IContactRepository
	{
		private readonly IDbConnection connection;

		public ContactRepository(IDbConnection connection)
		{
			this.connection = connection;
		}

		public Contact Select(int contactId)
		{
			var contact = connection.Query<Contact>("SELECT * FROM dbo.Contact WHERE ContactId = @ContactId", new {contactId});
			return contact.FirstOrDefault();
		}

		public IEnumerable<Contact> Select(ContactSelection selection)
		{
			return connection.Query<Contact>("SELECT * FROM dbo.Contact WHERE Active=1");
		}
	}
}