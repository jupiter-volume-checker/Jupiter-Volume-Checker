using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickerBlum
{
    public partial class AlignWindowFormAutoplay : Form
    {
        public AlignWindowFormAutoplay()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(750, 200);
        }
    }
}
