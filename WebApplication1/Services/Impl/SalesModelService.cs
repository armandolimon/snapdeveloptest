using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnapObjects.Data;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1
{
    /// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<ISalesModelService, SalesModelService>();
    /// </summary>
	
	public class SalesModelService : ISalesModelService
    {
        private readonly SalesDataContext _dataContext;

        public SalesModelService(SalesDataContext dataContext)
        {
            _dataContext = dataContext;
        }	

		public SalesModel RetrieveOne(int id)
        {
            return _dataContext.SqlModelMapper
                .LoadByKey<SalesModel>(id)
                .FirstOrDefault();
        }

        public IList<SalesModel> Retrieve()
        {
            return _dataContext.SqlModelMapper
                .Load<SalesModel>()
                .ToList();
        }
        public int Create(SalesModel salesmodel)
        {
            return _dataContext.SqlModelMapper
                .TrackCreate<SalesModel>(salesmodel)
                .SaveChanges()
                .InsertedCount;
        }
		
		public int Update(IModelEntry<SalesModel> salesmodel)
        {
            _dataContext.SqlModelMapper.Track(salesmodel);

            return _dataContext.SqlModelMapper
                .SaveChanges()
                .AffectedCount;
        }		
			
		public int Update(SalesModel salesmodel)
        {
            var oldSalesModel = this.RetrieveOne(salesmodel.Id);
            
            _dataContext.SqlModelMapper.TrackUpdate(oldSalesModel, salesmodel);
            
            return _dataContext.SqlModelMapper
                .SaveChanges()
                .ModifiedCount;
        }
		
		public int Delete(int id)
        {
            return _dataContext.SqlModelMapper
                .TrackDeleteByKey<SalesModel>(id)
                .SaveChanges()
                .DeletedCount;
        }
      
    }
}