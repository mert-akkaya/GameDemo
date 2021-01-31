using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Game:IEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        
    }
}
