using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Note : Property
    {
        public Note(int id, string title, string body) : base(id, title, body)
        {

        }
    }
}
