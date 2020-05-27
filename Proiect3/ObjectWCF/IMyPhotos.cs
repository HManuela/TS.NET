using System.Collections.Generic;

using WindowsFormsMyPhotos;
using ObjectWCF;

namespace ObjectWCF
{
   
        interface IMyPhotos
        {
          
            void AddImage(MyPhotos image);

            MyPhotos FindPhotoById(int id);

            void UpdatePhoto(MyPhotos image);

            void DeletePhotos(int id);

            bool ExistsPhoto(int id);



            
        }
    
}
