using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;
using Microsoft.Office.Interop.Outlook;

namespace TravelyseAddInNM
{
    public partial class TravelyseAddIn
    {
        Outlook.Inspectors inspectors;
        private ucPlanTravel ucPlanTravel;
        private Microsoft.Office.Tools.CustomTaskPane ctpTravelyse;
        private Dictionary<Outlook.Inspector, InspectorWrapper> inspectorWrappersValue = new Dictionary<Outlook.Inspector, InspectorWrapper>();

        private void TravelyseAddIn_Startup(object sender, System.EventArgs e)
        {
            UserControl2 ucTest = new UserControl2();
            ctpTravelyse = this.CustomTaskPanes.Add(ucTest, "Test");

            //ucPlanTravel = new ucPlanTravel();
            //ctpTravelyse = this.CustomTaskPanes.Add(ucPlanTravel, "Travelyse");

            ctpTravelyse.Visible = true;

            ctpTravelyse.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            //myCustomTaskPane.Height = 500;
            ctpTravelyse.Width = 400;

            inspectors = this.Application.Inspectors;
            inspectors.NewInspector += new Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);

            foreach (Outlook.Inspector inspector in inspectors)
            {
                Inspectors_NewInspector(inspector);
            }

            //inspectors = this.Application.Inspectors;
            //inspectors.NewInspector +=
            //new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);

        }

       

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new ArimonTravelyse();
        }

        public Dictionary<Outlook.Inspector, InspectorWrapper> InspectorWrappers
        {
            get
            {
                return inspectorWrappersValue;
            }
        }

        private void Inspectors_NewInspector(Outlook.Inspector Inspector)
        {
            if (Inspector.CurrentItem is Outlook.MailItem)
            {
                inspectorWrappersValue.Add(Inspector, new InspectorWrapper(Inspector));
            }
        }

        private void TravelyseAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785

            inspectors.NewInspector -= new Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);
            inspectors = null;
            inspectorWrappersValue = null;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(TravelyseAddIn_Startup);
            this.Shutdown += new System.EventHandler(TravelyseAddIn_Shutdown);
        }

        #endregion
    }

    public class InspectorWrapper
    {
        private Outlook.Inspector inspector;
        private CustomTaskPane taskPane;

        public InspectorWrapper(Inspector Inspector)
        {
            inspector = Inspector;

            UserControl2 ucTest = new UserControl2();

            taskPane = Globals.TravelyseAddIn.CustomTaskPanes.Add(ucTest, "Travelyse", inspector);
            taskPane.VisibleChanged += new EventHandler(TaskPane_VisibleChanged);

            ((InspectorEvents_Event)inspector).Close += new Outlook.InspectorEvents_CloseEventHandler(InspectorWrapper_Close);      
        }

        void TaskPane_VisibleChanged(object sender, EventArgs e)
        {
            Globals.Ribbons[inspector].RibbonTravelyse.tgbtnTravelyse.Checked = taskPane.Visible;
        }

        void InspectorWrapper_Close()
        {
            if (taskPane != null)
            {
                Globals.TravelyseAddIn.CustomTaskPanes.Remove(taskPane);
            }

            taskPane = null;
            Globals.TravelyseAddIn.InspectorWrappers.Remove(inspector);
            ((Outlook.InspectorEvents_Event)inspector).Close -= new Outlook.InspectorEvents_CloseEventHandler(InspectorWrapper_Close);
            inspector = null;
        }

        public CustomTaskPane CustomTaskPane
        {
            get
            {
                return taskPane;
            }
        }
    }
}