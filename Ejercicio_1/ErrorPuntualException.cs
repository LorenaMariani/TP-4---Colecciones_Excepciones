﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class ErrorPuntualException:ApplicationException
    {
        try{}
        catch (IndexOutOfRangeException)
            {}
           

    }
}
