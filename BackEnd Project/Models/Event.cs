﻿using System;

namespace BackEnd_Project.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }
    }
}