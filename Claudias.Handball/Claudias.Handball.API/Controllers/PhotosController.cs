using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Claudias.Handball.API.Controllers
{
    [RoutePrefix("api/photos")]
    public class PhotosController : ApiController
    {
        #region Methods
        //GET api/photos
        [HttpGet]
        [Route("")]
        public IEnumerable<Photo> ReadAll()
        {
            using (BusinessContext context = new BusinessContext())
            {
                return context.PhotoBusiness.ReadAll();
            }

        }
        #endregion
    }

}