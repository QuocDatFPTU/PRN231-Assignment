using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN231_Assignment.DomainModels.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        public string? QuestionName { get; set; }
        public DateTime? QuestionDateAndTime { get; set; }
        public int? UserId { get; set; }
        public int? CategoryId { get; set; }
        public int? VotesCount { get; set; }
        public int? AnswersCount { get; set; }
        public int? ViewsCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category? Category { get; set; }
        [ForeignKey("UserID")]
        public virtual User? User { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
