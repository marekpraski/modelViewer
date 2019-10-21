using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewer
{
    public class MyEventArgs : EventArgs
    {
        public string fileName { get; set; }
        public string selectedDirectoryId { get; set; }
        public string selectedUserId { get; set; }
    }
}
