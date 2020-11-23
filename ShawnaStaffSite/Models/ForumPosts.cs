﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shawna_Staff.Models
{
    public class ForumPosts
    {
        [Key]
        public int PostID { get; set; }

        [StringLength(60, MinimumLength = 2, ErrorMessage = "Post title must be between 2 and 60 characters")]
        [Required]
        public string PostTopic { get; set; }

        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Post must be between 2 and 1000 characters")]
        [Required]
        public string PostText { get; set; }

        //foreign key violation??
        [Required]
        public User Name { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Ratings must be between 1 and 5.")]
        public int PostRating { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
