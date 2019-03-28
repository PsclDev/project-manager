using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Property
    {
        private int _id;
        private string _text;

        public int ID { get => _id; set => _id = value; }
        public string Text { get => _text; set => _text = value; }

        public Property(int id, string text)
        {
            ID = id;
            Text = text;
        }
    }
}
