using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Option.Options;
using System.Configuration;
using PCAN;

namespace BioBotApp.Controls.Option
{
    public partial class frmOptions : Form
    {
        ctrCanConnector canCom = new ctrCanConnector();
        public frmOptions(DataSets.dsModuleStructure3 dsModuleStructure)
        {
            InitializeComponent();
            this.dsModuleStructure = dsModuleStructure;
        }

        private void tlvOptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //TODO: create a more generic way to identify the clicked node

            if (e.Node.Name.Equals("nodeDB"))
            {
                setOptionControl(new optionDBConnection());
            }
            else if (e.Node.Name.Equals("nodeActionTypes"))
            {
                setOptionControl(new optionActionType(this.dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeActionValueTypes"))
            {
                setOptionControl(new optionActionValueType(this.dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeModuleTypes"))
            {
                setOptionControl(new optionModuleType(this.dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeModuleTypesActionTypes"))
            {
                setOptionControl(new optionModuleTypeActionType(this.dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeCom"))
            {
                setOptionControl(new optionCommunication());
            }
            else if (e.Node.Name.Equals("nodeGCode"))
            {
                setOptionControl(new optionCustomSerial("Serial port : Gcode", "test gcode"));
            }
            else if (e.Node.Name.Equals("nodeCan"))
            {
                setOptionControl(canCom);
            }
            else if (e.Node.Name.Equals("nodeLabwareTypesLabwareParameterTypes"))
            {
                setOptionControl(new optionLabwareTypeLabwareParameterType(dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeLabwareTypes"))
            {
                setOptionControl(new optionLabwareType(dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeLabwareParameterTypes"))
            {
                setOptionControl(new optionLabwareParameterType(dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeMovement"))
            {
                setOptionControl(new optionMovement(dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeProtocol"))
            {
                setOptionControl(new optionProtocol(dsModuleStructure));
            }
            else if (e.Node.Name.Equals("nodeModuleTypeLabwareParameterType"))
            {
                setOptionControl(new optionModuleTypeLabwareParameterType(dsModuleStructure));

            }
            else if (e.Node.Name.Equals("nodeJoypad"))
            {
                setOptionControl(new optionJoypad());

            }
            else
            {
                //  setOptionControl(new optionActionValueType());
            }
        }

        public void setDataSet(DataSets.dsModuleStructure3 dsModuleStructure)
        {
            this.dsModuleStructure = dsModuleStructure;
        }

        /// <summary>
        /// Function that sets the center control
        /// </summary>
        /// <param name="optionControl">The user control to be set</param>
        private void setOptionControl(UserControl optionControl)
        {
            if (optionControl.Tag == null)
            {
                throw new System.ArgumentException("Option control tag is null !");
            }

            this.lblTitle.Text = optionControl.Tag.ToString();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(optionControl);
            optionControl.Dock = DockStyle.Fill;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
