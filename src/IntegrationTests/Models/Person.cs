﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Neo4jMapper;

namespace IntegrationTests.Models
{
    public class Person
    {
        [NodeId]
        [IgnoreDataMember]
        public long Id { get; set; }

        public string name { get; set; }
        public int born { get; set; }

        public IEnumerable<Movie> MovesActedIn { get; set; }
    }
}
