using System;
using System.Collections.Generic;
using System.Text;

namespace Wheeler.Model.DbEntities
{
    public class AppUsers
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUsers Users { get; set; }
        public virtual PersonalDetail PersonalDetail { get; set; }
    }
}
