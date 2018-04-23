using System;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace RibbonDesigner {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            XtraReport1 rep = new XtraReport1();
            XRDesignRibbonFormEx form = new XRDesignRibbonFormEx();
            form.DesignPanel.OpenReport(rep);
            form.ShowDialog();
            Close();
        }
    }
}