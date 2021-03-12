using Assessment.Data;
using Assessment.Services.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SynicTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment.Services
{
    public class BlogService : BaseService<AssessmentDataContext, Blog, BlogFilters>, IBlogService
    {
        public BlogService(AssessmentDataContext context)
            : base(context, x => x.Blogs)
        {

        }

        public override ServiceResult<Blog> CreateUpdate(Blog entity)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Blog> Get(BlogFilters filters, params Func<IQueryable<Blog>, IIncludableQueryable<Blog, object>>[] includes)
        {
            //var res = this.All(filters, includes);
            IQueryable<Blog> res = base.Context.Blogs.Include(x => x.Author);


            return res;
        }
    }

    public interface IBlogService
    {
        IQueryable<Blog> All(BlogFilters filters, params Func<IQueryable<Blog>, IIncludableQueryable<Blog, object>>[] includes);
        ServiceResult<Blog> CreateUpdate(Blog entity);
        ServiceResult<Blog> DeleteById(int id);
        IQueryable<Blog> Get(BlogFilters filters = null, params Func<IQueryable<Blog>, IIncludableQueryable<Blog, object>>[] includes);
        ServiceResult<Blog> GetById(int id, params Func<IQueryable<Blog>, IIncludableQueryable<Blog, object>>[] includes);
        ServiceResult<IPageOfList<Blog>> GetPage(BlogFilters filters, int? page = null, int? size = null, params Func<IQueryable<Blog>, IIncludableQueryable<Blog, object>>[] includes);
    }
}
