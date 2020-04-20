using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace MyPhotos.Api
{
    public class MyPhotosApi
    {
        private readonly MyPhotosModelContainer _context;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public MyPhotosApi()
        {
            _context = new MyPhotosModelContainer();
        }

        public User FindUser(string nume, string prenume, string phoneNumber)
        {
            if (string.IsNullOrEmpty(nume))
            {
                throw new ArgumentException("Nume must not be null or empty.");
            }

            if (string.IsNullOrEmpty(prenume))
            {
                throw new ArgumentException("Prenume must not be null or empty.");
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentException("Phone number must not be null or empty");
            }

            User user = _context.Users.FirstOrDefault(c =>
                c.Nume.Equals(nume) && c.Prenume.Equals(prenume) && c.Telefon.Equals(phoneNumber));

            return user;
        }

        public void AddUser(User user)
        {
         
            _context.Clienti.Add(user);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.Clienti.ToList();
        }

        

        public void AddImage(Photos image)
        {
            if (image == null)
            {
                throw new ArgumentException("Image must not be null.");
            }

            _context.Photos.Add(image);
            _context.SaveChanges();
        }

       

        public User FindUserById(int id)
        {
            return _context.Users.Find(id);
        }

       
       

        private void ExecuteQuery(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Photos FindPhotoById(int id)
        {
            return _context.Photos.Find(id);
        }

        public Users FindUserById(int id)
        {
            return _context.Users.Find(id);
        }

       
        public void UpdatePhoto(Photos image)
        {
            if (image == null)
            {
                throw new ArgumentException("Image must not be null.");
            }

            var toUpdate = _context.Photos.Find(image.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(image);
            _context.SaveChanges();
        }

        public void DeletePhotos(int id)
        {
            if (!ExistsPhoto(id)) return;

            var image = _context.Photos.First(c => c.Id == id);

            ExecuteQuery($"DELETE FROM PhotoaDetaliPhoto WHERE Photos_Id = {image.Id};");

            _context.Imagini.Remove(image);
            _context.SaveChanges();
        }

        private bool ExistsPhoto(int id)
        {
            return _context.Photos.Any(c => c.Id == id);
        }

        
    }
}