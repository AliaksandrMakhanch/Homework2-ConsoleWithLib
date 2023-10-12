using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace HomeWork2
{
    public static class Concatenationlib
    {
        public static string Concatenate(string name)
        {
            var currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            return $"{currentTime} Welcome {name} to dotnet world";
        }
    }
}