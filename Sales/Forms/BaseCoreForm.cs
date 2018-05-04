using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales.Forms
{
    public partial class BaseCoreForm : Form
    {
        public BaseCoreForm()
        {
            InitializeComponent();
        }

        public BaseCoreForm(AppCore appCore)
        {
            InitializeComponent();
            AppCore = appCore;
        }

        protected AppCore AppCore { get; private set; }
    }
}
