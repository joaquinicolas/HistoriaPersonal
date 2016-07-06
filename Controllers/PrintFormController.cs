using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HistoriaPersonalCormillot.Controllers
{
    public class PrintFormController : ApiController
    {
        CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();

        public class UsuarioModel
        {
             public string Username { get; set; }
            public int Id { get; set; }
        }
        // GET api/printform
        public IEnumerable<string> Get()
        {
            return null;
        }

        // GET api/printform/5
        public IQueryable<UsuarioModel> Get(String userName)
        {
            return model.Usuario.Select(x => new UsuarioModel()
            {
                Username = x.Username,
                Id = x.Id
            }).Where(x => x.Username.Equals(userName));
        }

        // POST api/printform
        public void Post([FromBody]string value)
        {
        }

        // PUT api/printform/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/printform/5
        public void Delete(int id)
        {
        }
    }
}
