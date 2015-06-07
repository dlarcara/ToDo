using System.Collections;
using System.Collections.Generic;
using System.Web.Http;

namespace ToDoApi.Controllers
{
    public class ToDoController : ApiController
    {
        public IEnumerable<ToDoView> Get()
        {
            return new List<ToDoView>
            {
                new ToDoView
                {
                    Description = "Use JSON serializer instead of XML"
                },
                new ToDoView
                {
                    Description = "Add Validation To Controller"
                },
                new ToDoView
                {
                    Description = "Proper HTTP Exceptions"
                },
                new ToDoView
                {
                    Description = "Add Queryable To Controller (oData)"
                }
            };
        }
    }
}
