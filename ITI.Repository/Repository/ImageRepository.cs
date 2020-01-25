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
        protected MGTTCEntities mGTTCEntities;
        public ImageRepository()
        {
            mGTTCEntities = new MGTTCEntities();
        }
        public List<ImageGallery> GetImageGalleries()
        {
            return mGTTCEntities.ImageGalleries.ToList();
        }
        public ImageGallery GetImageGalleryById(int id)
        {
            return mGTTCEntities.ImageGalleries.FirstOrDefault(x => x.ID == id);
        }
        public ImageGallery InsertImage(ImageGallery imageGallery)
        {
            var inserted = mGTTCEntities.ImageGalleries.Add(imageGallery);
            mGTTCEntities.SaveChanges();
            return inserted;
        }
        public ImageGallery UpdateImage(ImageGallery imageGallery)
        {
            mGTTCEntities.Entry(imageGallery).State = EntityState.Modified;
            mGTTCEntities.SaveChanges();
            return imageGallery;
        }
        public void DeleteImage(int id)
        {
            var image = mGTTCEntities.ImageGalleries.FirstOrDefault(x => x.ID == id);
            mGTTCEntities.ImageGalleries.Remove(image);
            mGTTCEntities.SaveChanges();
        }
    }
}
