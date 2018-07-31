using System.Collections.Generic;
using System.Threading.Tasks;
using Excalibur.Domain;
using Excalibur.Shared.Services;
using Xciles.Uncommon.Net;

namespace Excalibur.Services
{
    public class TodoService : ServiceBase<IList<Todo>>
    {
        public override async Task<IList<Todo>> SyncDataAsync()
        {
            var result = await UncommonRequestHelper.ProcessGetRequestAsync<IList<Todo>>("https://jsonplaceholder.typicode.com/todos");

            return result.Result;
        }
    }
}
