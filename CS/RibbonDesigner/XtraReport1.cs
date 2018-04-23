using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace RibbonDesigner {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
            PrintTool.MakeCommandResponsive(this.PrintingSystem);
            PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
        }
    }
}
