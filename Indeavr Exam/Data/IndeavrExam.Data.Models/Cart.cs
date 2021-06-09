using System;
using System.Collections.Generic;

using IndeavrExam.Data.Common.Models;

namespace IndeavrExam.Data.Models
{
    public class Cart : BaseModel<string>
    {
        public Cart()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Game> Games { get; set; }
            = new HashSet<Game>();
    }
}