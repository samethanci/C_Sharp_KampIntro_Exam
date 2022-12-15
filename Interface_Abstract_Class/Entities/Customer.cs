using System;
using System.Collections.Generic;
using System.Text;
using Interface_Abstract_Class.Abstract;

namespace Interface_Abstract_Class.Entities
{
    internal class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
