using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnapObjects.Data;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1
{
	public interface ISalesModelService
	{	
		SalesModel RetrieveOne(int id);
		
		IList<SalesModel> Retrieve();
		
		int Create(SalesModel salesmodel);
		
		int Update(IModelEntry<SalesModel> salesmodel);
	
		int Update(SalesModel salesmodel);
		
		int Delete(int id);
    }
}