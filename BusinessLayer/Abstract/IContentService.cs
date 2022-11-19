using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();

        List<Content> GetListByHeadingID(int id);//ID ye göre bana tüm listeyi döndür.

        void ContentAdd(Content content);

        Content GetByID(int id); //Sen ıd ye göre işlem yapacaksın

        void ContentDelete(Content content);

        void ContentUpdate(Content content);

    }
}
