using System;
using System.Drawing;

namespace MyContacts
{
    [Serializable] //Attribue "Serializable" permettant de sauvegarder l'objet
    public class Contact
    {
        //Variables
        private string firstName;
        private string lastName;
        private string email;
        private string tel;
        private string address;
        private string city;
        private Image photo;
        private bool favorite;

        //Properties
        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public string Email { get => email; private set => email = value; }
        public string Tel { get => tel; private set => tel = value; }
        public string Address { get => address; private set => address = value; }
        public string City { get => city; private set => city = value; }
        public Image Photo { get => photo; private set => photo = value; }
        public bool Favorite { get => favorite; set => favorite = value; }

        //Constructors
        public Contact() 
        { 
        
        }

        public Contact(string firstName, string lastName, string email, string tel, string address, string city, Image photo, bool favorite = false)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Tel = tel;
            this.Address = address;
            this.City = city;
            this.Photo = photo;
            this.favorite = favorite;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
