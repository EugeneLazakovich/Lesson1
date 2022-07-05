﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson1_DAL
{
    public class Library
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public City City { get; set; }
        [Required]
        public Location Location { get; set; }
        public List<Book> Books { get; set; }
    }
}
