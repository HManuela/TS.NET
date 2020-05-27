using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MyPhotos;
using MyPhotos.Api;

namespace ServiceWCF
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyPhotos : IMyPhotos
    {
        private readonly MyPhotosApi _api;

        public MyPhotos()
        {
            _api = new MyPhotosApi();
        }

        public User FindCustomer(string nume, string prenume, string phoneNumber)
        {
            return _api.FindUsers(nume, prenume, phoneNumber);
        }

        public void AddUser(User user)
        {
            _api.AddUser(user);
        }

        public List<Client> GetAllUsers()
        {
            return _api.GetAllUsers();
        }


        public void AddImage(Imagine image)
        {
            _api.AddImage(image);
        }


        public Material FindUserById(int id)
        {
            return _api.FindUserById(id);
        }

        public Operatie FindPhotoById(int id)
        {
            return _api.FindPhotoById(id);
        }


        void UpdatePhoto(Photos image)
        {
            return _api.UpdatePhoto(image);
        }

        void DeletePhotos(int id)
        {
            return _api.DeletePhotos(id);

        }

        bool ExistsPhoto(int id)
        {
            return _api.ExistsPhoto(id);
        }

    }
}
