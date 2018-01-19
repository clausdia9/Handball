using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Claudias.Handball.API.Controllers
{
    [RoutePrefix("api/team")]
    public class TeamController : ApiController
    {
        #region Methods
        //GET api/team
        [HttpGet]
        [Route("")]
        public IEnumerable<Player> ReadAll()
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.PlayerBusiness.ReadAll();
            }
        }

        //GET api/team/{Guid}
        [HttpGet]
        [Route("{playerId:Guid}")]
        public Player ReadById(Guid playerId)
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.PlayerBusiness.ReadById(playerId);
            }
        }

        //POST api/team
        [HttpPost]
        [Route("")]
        public void Insert([FromBody] Player player)
        {
            using (BusinessContext context = new BusinessContext())
            {
                context.PlayerBusiness.Insert(player);
            }
        }
        //PUT api/team
        [HttpPut]
        [Route("")]
        public void Update([FromBody] Player player)
        {
            using (BusinessContext context = new BusinessContext())
            {
                context.PlayerBusiness.Update(player);
            }
        }
        //DELETE api/team
        [HttpDelete]
        [Route("{playerId:Guid}")]
        public void Delete(Guid playerId)
        {
            using (BusinessContext context = new BusinessContext())
            {
                context.PlayerBusiness.Delete(playerId);
            }
        }
        #endregion
    }
}