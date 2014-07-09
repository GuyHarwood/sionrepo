using System.Collections.Generic;

namespace domain
{
	public class ContactService
	{
		private readonly IContactRepository contactRepository;

		public ContactService(IContactRepository contactRepository)
		{
			this.contactRepository = contactRepository;
		}

		public Contact GetBy(int contactId)
		{
			//validation etc. ....

			var dataObject = contactRepository.Select(contactId);

			//map to business object

			var businessObject = dataObject;

			return businessObject;
		}

		public IEnumerable<Contact> GetActive()
		{
			//validation etc. ....

			var data = contactRepository.Select(ContactSelection.Active);

			//map to business object with auto mapper etc...

			var contacts = data;

			return contacts;
		}
		/*
		 * return new[]
			{
				new Contact()
				{
					Id = 1,
					Name = "Sion"
				},
				new Contact()
				{
					Id = 2,
					Name = "Sid"
				}
			};
		 * 
		 */
	}

	public enum ContactSelection
	{
		Active,
		All,
		Inactive,
		Deleted
	}
}