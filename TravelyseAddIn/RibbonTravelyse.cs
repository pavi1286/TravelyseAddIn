using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools;

namespace TravelyseAddInNM
{
    public partial class ArimonTravelyse
    {
        private void RibbonTravelyse_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void tgbtnTravelyse_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Inspector inspector = (Outlook.Inspector)e.Control.Context;
            InspectorWrapper inspectorWrapper = Globals.TravelyseAddIn.InspectorWrappers[inspector];
            CustomTaskPane taskPane = inspectorWrapper.CustomTaskPane;
            taskPane.Visible = true;
            if (taskPane != null)
            {
                taskPane.Visible = true;
                    //((RibbonToggleButton)sender).Checked;
            }
        }
    }
}
