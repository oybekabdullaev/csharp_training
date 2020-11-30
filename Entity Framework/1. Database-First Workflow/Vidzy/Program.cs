using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new VidzyDbContext();
            dbContext.AddVideo("Video 5", DateTime.Now, "Comedy", Classification.Gold);
        }
    }
}
