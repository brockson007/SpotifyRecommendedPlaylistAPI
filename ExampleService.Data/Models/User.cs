using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleService.Data.Models
{
    public class User
    {
        public User()
        {
        }

        public Int32 UserID { get; set; }

        public String Name { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }

        public String Phone { get; set; }

    }
}
