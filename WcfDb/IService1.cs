using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDb
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IService1
	{
		

		[OperationContract]
		int InsertPerson(Person p);

		[OperationContract]
		int UpdatePerson(Person p);

		[OperationContract]
		int DeletePerson(Person p);

		[OperationContract]
		Person GetPerson(Person p);

		[OperationContract]
		List<Person> GetAllPeople();

		
	}

	
}
