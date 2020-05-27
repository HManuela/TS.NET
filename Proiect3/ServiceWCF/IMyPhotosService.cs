using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyPhotosService;

namespace ServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyPhotos
    {
        [OperationContract]
        User FindUser(string nume, string prenume, string phoneNumber);

        [OperationContract]
        void AddUser(User user);

        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        void AddImage(Photos image);

        [OperationContract]
        User FindUserById(int id);

        [OperationContract]
        Photos FindPhotoById(int id);

        [OperationContract]
        void UpdatePhoto(Photos image);

        [OperationContract]
        void DeletePhotos(int id);

        [OperationContract]
        bool ExistsPhoto(int id);

    }
}