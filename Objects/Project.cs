﻿using System;

namespace ProjectsGenerator_WindowsForms_2.Objects
{
    public class Project
    {
        public int id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectCompany { get; set; }
        public string ProjectState { get; set; }
        public DateTime? ProjectDateIn { get; set; }
        public DateTime? ProjectDateOut { get; set; }
        public int? ImageId { get; set; }
    }
}