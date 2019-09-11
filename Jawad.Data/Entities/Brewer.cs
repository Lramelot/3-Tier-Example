﻿using System.Collections.Generic;

namespace Jawad.Data.Entities
{
    public class Brewer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public ICollection<Beer> Beers { get; set; }
    }
}