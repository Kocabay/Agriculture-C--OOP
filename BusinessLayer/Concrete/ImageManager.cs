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
    public class ImageManager : IImageService
    {
     private readonly   IImageDal _ımagedal;

        public ImageManager(IImageDal ımagedal)
        {
            _ımagedal = ımagedal;
        }

        public void Delete(Image t)
        {
           _ımagedal.Delete(t);
        }

        public Image GetById(int id)
        {
       return _ımagedal.GetById(id);
        }

        public List<Image> GetListAll()
        {
           return _ımagedal.GetListAll();
        }

        public void Insert(Image t)
        {
            _ımagedal.Insert(t);
        }

        public void Update(Image t)
        {
          _ımagedal.Update(t);
        }
    }
}


