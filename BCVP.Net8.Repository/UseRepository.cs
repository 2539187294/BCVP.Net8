using BCVP.Net8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BCVP.Net8.Repository
{
    public class UseRepository : IUseRepository
    {
        public async Task<List<User>> GetUser()
        {
            await Task.CompletedTask;
            var data = "[{\"Id\": 18, \"Name\":\"laozhang\"}]";

            return JsonConvert.DeserializeObject<List<User>>(data) ?? new List<User>();
        }
    }
}
