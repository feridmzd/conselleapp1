﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public  class ClasroomNotFoundException:Exception
    {
        public ClasroomNotFoundException(string message):base(message) { }
    }
}
