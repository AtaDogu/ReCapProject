using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Colour:IEntity
    {
        public int ColourId { get; set; }
        public string ColourName { get; set; }
    }
}
