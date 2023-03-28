﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public int ProfilePictureURL { get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}