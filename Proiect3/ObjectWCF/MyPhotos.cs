using System.Collections.Generic;
using MyPhotos;
using MyPhotos.Api;

namespace ObjectWCF
{
    public class MyPhotos : IMyPhotos
    {
        private readonly MyPhotos _api;

        public MyPhotos()
        {
            _api = new MyPhotosApi();
        }

        public User FindUser(string nume, string prenume, string phoneNumber)
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