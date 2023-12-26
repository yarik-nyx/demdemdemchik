using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;

namespace agents
{
    public class MyList
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string Type { get; set; }

        public string? Phone { get; set; }
        
        public string Sales { get; set; }

        public Bitmap Logo { get; set; }

        public string Priority { get; set; }



    }
}
