using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeCamp2012LiveAgain.Models;

namespace CodeCamp2012LiveAgain.Controllers
{
    public class HorseController : ApiController
    {
        HorseRepository repository = new HorseRepository();

        /// <summary>
        /// Gets all the horses
        /// </summary>
        /// <returns>Returs a horse resource</returns>
        public IEnumerable<Horse> Get()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Gets a horse by ID
        /// </summary>
        /// <param name="id">Id of the horse</param>
        /// <returns>the horse</returns>
        public Horse Get(int id)
        {
            return repository.Get(id);
        }

        /// <summary>
        /// Use this to create a horse
        /// </summary>
        /// <param name="value">the horse to create</param>
        public void Post([FromBody]Horse value)
        {
             repository.Post(value);
        }

        // PUT api/horse/5
        public void Put(int id, [FromBody]Horse value)
        {
             repository.Update(value);
        }

        // DELETE api/horse/5
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
