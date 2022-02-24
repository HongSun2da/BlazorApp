﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }        
        public bool IsDone {get; set; }
        public DateTime Date { get; set; }

    }
}
