﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TigApp.Models
{
    public class Work
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
