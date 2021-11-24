using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedTextAdventure
{
    public class items
    {
        private string m_name;
        private string m_description;

        public string itemname { get { return m_name;} set{m_name = value; } }
        public string itemdescription { get { return m_description; } set { m_description = value; } }
    }
}
