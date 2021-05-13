using System;
using System.Collections.Generic;
using System.Text;
using Wheeler.Model.DbEntities;

namespace Wheeler.Model.DbEntities
{
    public class PersonalDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int AppUserId { get; set; }
        public AppUsers  AppUsers { get; set; }
    }
}
