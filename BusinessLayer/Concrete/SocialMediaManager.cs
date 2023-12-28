using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {

        ISocialMediaDal _socialmediadal;

        public SocialMediaManager(ISocialMediaDal socialmediadal)
        {
            _socialmediadal = socialmediadal;
        }

        public void Delete(SocialMedia t)
        {
         _socialmediadal.Delete(t);
        }

        public SocialMedia GetById(int id)
        {
           return _socialmediadal.GetById(id);
        }

        public List<SocialMedia> GetListAll()
        {
            return _socialmediadal.GetListAll();
        }

        public void Insert(SocialMedia t)
        {
            _socialmediadal.Insert(t);
        }

        public void Update(SocialMedia t)
        {
            _socialmediadal.Update(t);
        }
    }
}
