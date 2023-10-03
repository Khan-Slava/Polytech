using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polytech.DAL.Model
{

    public class Client
    {
        public Client() : this(0)
        {

        }
        public Client(int Id) : this(Id, DateTime.Now)
        {
            this.Id = Id;
        }
        public Client(int Id, DateTime CreateDate) : this(Id, CreateDate, "")
        {
            this.Id = Id;
        }
        public Client(int Id, DateTime CreateDate, string PathToImage)
        {
            this.Id = Id;
            this.CreateDate = CreateDate;
            this.PathToImage = PathToImage;

        }
        /*int age;*/
        /*public int Id
        {
            get { return Id; }

            set
            {
                if (value < 0)
                    Id = 0;
                else
                    Id = value;
            }

        }*/
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string LName { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1} {2}", FName, SName, LName); }
        }
        public string ShortName
        {
            get
            {

                if (string.IsNullOrWhiteSpace(LName)) return string.Format("{0} {1}. {2}.", FName, SName[0], LName[0]);
                else
                    return string.Format("{0} {1}. {2}.", FName, SName[0], "");

                return string.Format("{0} {1}. {2}.", FName, SName[0], !string.IsNullOrWhiteSpace(LName) != null ? LName[0].ToString() : "");
            }
        }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int sex { get; set; }

        public DateTime Dob { get; set; }
        public int age
        {
            get
            {
                return age;
            }
        }
        public string PathToImage { get; set; }
        public Address Address { get; set; }
        public Account[] Accounts { get; set; }
    }
}
