using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IBlogService
    {
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
        List<Blog> GetList();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
    }
}
