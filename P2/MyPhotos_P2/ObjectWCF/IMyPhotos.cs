using System.Collections.Generic;
using System.ServiceModel;
using WindowsFormsMyPhotos;
using MyPhotosModel;
using MyPhotos.Api;

namespace ObjectWCF
{
   
        interface IMyPhotos
        {
            User FindUser(string nume, string prenume, string phoneNumber);
            
            void AddUser(User user);

            List<User> GetAllUsers();

            void AddImage(Photos image);

            User FindUserById(int id);

            Photos FindPhotoById(int id);

            void UpdatePhoto(Photos image);

            void DeletePhotos(int id);

            bool ExistsPhoto(int id);



            
        }
    
}
