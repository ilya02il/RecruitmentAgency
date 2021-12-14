using RecruitmentAgency.Presentations.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class AgencyMainForm : Form, IAgencyMainView
    {
        private readonly ApplicationContext _context;

        public AgencyMainForm(ApplicationContext context)
        {
            _context = context;

            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;

            if (Application.OpenForms.Count > 0)
            {
                base.Show();
            }
            else
            {
                Application.Run(_context);
            }
        }
    }
}
