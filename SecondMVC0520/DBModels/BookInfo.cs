using SecondMVC0520.Models;
using System;
using System.Collections.Generic;

namespace SecondMVC0520.DBModels
{
    public partial class BookInfo:BaseEntity
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public string? Name { get; set; }
    }
}
