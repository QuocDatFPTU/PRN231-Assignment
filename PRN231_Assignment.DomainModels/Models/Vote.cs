using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN231_Assignment.DomainModels.Models
{
    public partial class Vote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VoteId { get; set; }
        public int? UserId { get; set; }
        public int? AnswerId { get; set; }
        public int? VoteValue { get; set; }

        public virtual Answer? Answer { get; set; }
        public virtual User? User { get; set; }
    }
}
