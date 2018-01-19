using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Claudias.Handball.API.Controllers
{
    [RoutePrefix("api/schedule")]
    public class ScheduleController : ApiController
    {
        #region Methods
        //GET api/schedule
        [HttpGet]
        [Route("")]
        public IEnumerable<NextEvent> ReadAll()
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.NextEventBusiness.ReadAll();
            }
        }

        //GET api/schedule/{Guid}
        [HttpGet]
        [Route("{nextEventId:Guid}")]
        public NextEvent ReadById(Guid nextEventId)
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.NextEventBusiness.ReadById(nextEventId);
            }
        }

        //POST api/schedule
        [HttpPost]
        [Route("")]
        public void Insert([FromBody] NextEvent nextEvent)
        {
            using (BusinessContext context = new BusinessContext())
            {
                context.NextEventBusiness.Insert(nextEvent);
            }
        }
        //PUT api/schedule
        [HttpPut]
        [Route("")]
        public void Update([FromBody] NextEvent nextEvent)
        {
            using (BusinessContext context = new BusinessContext())
            {
                context.NextEventBusiness.Update(nextEvent);
            }
        }
        //DELETE api/schedule/{Guid}
        [HttpDelete]
        [Route("{nextEventId:Guid}")]
        public void Delete(Guid nextEventId)
        {
            using (BusinessContext context = new BusinessContext())
            {
                context.NextEventBusiness.Delete(nextEventId);
            }
        }
        #endregion
    }

}