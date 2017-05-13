using ProjectZakynthos.Persistence;
using System;
using System.Web.Http;

namespace ProjectZakynthos.Web.Controllers
{
    public class ItemController : ApiController
    {
        IItemRepository reporitory;

        public ItemController(IItemRepository repository)
        {
            this.reporitory = repository;
        }
        
        // api/item/5
        public string Get(int id)
        {
            return reporitory.Create("hello").ToString();
        }
    }
}
