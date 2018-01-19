using Claudias.Handball.Business.Core;
using Claudias.Handball.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Claudias.Handball.API.Controllers
{
    [RoutePrefix("api/news")]
    public class NewsController : ApiController
    {
            #region Methods
            //GET api/news
            [HttpGet]
            [Route("")]
            public IEnumerable<Article> ReadAll()
            {
                using (BusinessContext context = new BusinessContext())
                {
                    return context.ArticleBusiness.ReadAll();
                }
            }

            //GET api/news/{Guid}
            [HttpGet]
            [Route("{articleId:Guid}")]
            public Article ReadById(Guid articleId)
            {
                using (BusinessContext context = new BusinessContext())
                {
                    return context.ArticleBusiness.ReadById(articleId);
                }
            }

            //POST api/news
            [HttpPost]
            [Route("")]
            public void Insert([FromBody] Article article)
            {
                using (BusinessContext context = new BusinessContext())
                {
                    context.ArticleBusiness.Insert(article);
                }
            }
             //PUT api/news
            [HttpPut]
            [Route("")]
            public void Update([FromBody] Article article)
            {
                using (BusinessContext context = new BusinessContext())
                {
                    context.ArticleBusiness.Update(article);
                }
            }
            //DELETE api/news/{Guid}
            [HttpDelete]
            [Route("{articleId:Guid}")]
            public void Delete(Guid articleId)
            {
                using (BusinessContext context = new BusinessContext())
                {
                    context.ArticleBusiness.Delete(articleId);
                }
            }
            #endregion
    }
    
}