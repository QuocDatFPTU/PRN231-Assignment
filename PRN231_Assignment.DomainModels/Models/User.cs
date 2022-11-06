using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PRN231_Assignment.DomainModels.Models
{
    public partial class User
    {
        public User()
        {
            Answers = new HashSet<Answer>();
            Questions = new HashSet<Question>();
            Votes = new HashSet<Vote>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
