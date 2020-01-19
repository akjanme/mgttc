using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;
using System.Data.Entity;

namespace ITI.Repository.Repository
{
    public class ImageRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public ImageRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<ImageGallery> GetImageGalleries()
        {
            return iTIDataEntities.ImageGalleries.ToList();
        }
        public ImageGallery GetImageGalleryById(int id)
        {
            return iTIDataEntities.ImageGalleries.FirstOrDefault(x => x.ID == id);
        }
        public ImageGallery InsertImage(ImageGallery imageGallery)
        {
            var inserted = iTIDataEntities.ImageGalleries.Add(imageGallery);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public ImageGallery UpdateImage(ImageGallery imageGallery)
        {
            iTIDataEntities.Entry(imageGallery).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return imageGallery;
        }
        public void DeleteImage(int id)
        {
            var image = iTIDataEntities.ImageGalleries.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.ImageGalleries.Remove(image);
            iTIDataEntities.SaveChanges();
        }
    }
}
