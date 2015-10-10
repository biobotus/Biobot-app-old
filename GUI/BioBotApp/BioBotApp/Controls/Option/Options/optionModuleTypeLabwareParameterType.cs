using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Option.Options
{
    public partial class optionModuleTypeLabwareParameterType : UserControl
    {
        public optionModuleTypeLabwareParameterType()
        {
            InitializeComponent();
        }

        public optionModuleTypeLabwareParameterType(DataSets.dsModuleStructure3 dsModuleStructure)
            :this()
        {
            this.dsModuleStructureGUI = dsModuleStructure;
            this.bsModuleType.DataSource = dsModuleStructureGUI;
            bsLabwareParameterType.DataSource = dsModuleStructureGUI;
            this.bsModuleTypedtModuleTypeLabwareParameterType.DataMember = "dtModuleType_dtModuleTypeLabwareParameterType";
            this.bsModuleTypedtModuleTypeLabwareParameterType.DataSource = this.bsModuleType;
            /*
            this.dsLabwareStructureGUI = dtLabwareStructure;
            this.dsModuleStructureGUI = dsModuleStructure;

            bsLabwareType.DataSource = dsLabwareStructureGUI;
            bsLabwareTypeLabwareParameterType.DataSource = dsLabwareStructureGUI;

            if(dsLabwareStructureGUI.dtLabwareParameterType.Count == 0)
            {
                taLabwareParameterType.Fill(dsLabwareStructureGUI.dtLabwareParameterType);
            }

            if(dsLabwareStructureGUI.dtLabwareType.Count == 0)
            {
                taLabwareType.Fill(dsLabwareStructureGUI.dtLabwareType);
            }
             * */
        }

        private void bsLabwareType_CurrentChanged(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure3.dtModuleTypeRow row = getSelectedModuleType();
            if(row == null)
            {
                return;
            }
            
        }

        public DataSets.dsModuleStructure3.dtModuleTypeRow getSelectedModuleType()
        {
            DataSets.dsModuleStructure3.dtModuleTypeRow row;

            if (bsModuleType.Current == null)
            {
                return null;
            }

            DataRowView rowView = bsModuleType.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure3.dtModuleTypeRow;
            return row;
        }

        private void crudOptions_AddClickHandler(object sender, EventArgs e)
        {
            /*
            DataSets.dsModuleStructure3.dtLabwareTypeLabwareParameterTypeRow labwareParameterType =
                dsModuleStructureGUI.dtLabwareTypeLabwareParameterType.NewdtLabwareTypeLabwareParameterTypeRow();
            DataSets.dsModuleStructure3.dtLabwareTypeRow labwareRow = getSelectedLabwareTypeRow();
            */

            abstractDialog dialog = new abstractDialog("Action type", "Add");

            namedInputTextBox description = new namedInputTextBox("Description: ");
            dialog.addNamedInputTextBox(description);

            namedComboBox cbActionValueTupe = new namedComboBox("Labware parameter: ");

            cbActionValueTupe.getComboBox().DataSource = bsLabwareParameterType;
            cbActionValueTupe.getComboBox().DisplayMember = "description";

            dialog.addControl(cbActionValueTupe);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure3.dtModuleTypeLabwareParameterTypeRow row = dsModuleStructureGUI.dtModuleTypeLabwareParameterType.NewdtModuleTypeLabwareParameterTypeRow();
                DataSets.dsModuleStructure3.dtLabwareParameterTypeRow dtLabwareParameterTypeRow = getSelectedLabwareParameterTypeRow();
                DataSets.dsModuleStructure3.dtModuleTypeRow dtModuleTypeRow = getSelectedModuleType();

                if(dtLabwareParameterTypeRow == null)
                {
                    return;
                }

                if(dtModuleTypeRow == null)
                {
                    return;
                }

                row.fk_labware_parameter_type_id = dtLabwareParameterTypeRow.pk_id;
                row.fk_module_type_id = dtModuleTypeRow.pk_id;
                row.value = description.getInputTextValue();

                dsModuleStructureGUI.dtModuleTypeLabwareParameterType.AdddtModuleTypeLabwareParameterTypeRow(row);
                updateRow(row);
            }


        }
        public DataSets.dsModuleStructure3.dtLabwareParameterTypeRow getSelectedLabwareParameterTypeRow()
        {
            DataSets.dsModuleStructure3.dtLabwareParameterTypeRow row;

            if (bsLabwareParameterType.Current == null)
            {
                return null;
            }

            DataRowView rowView = bsLabwareParameterType.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure3.dtLabwareParameterTypeRow;
            return row;
        }

        public void updateRow(DataSets.dsModuleStructure3.dtModuleTypeLabwareParameterTypeRow updateRow)
        {
            try
            {
                taModuleTypeLabwareParameterTypeTableAdapte.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action type, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsModuleStructureGUI.RejectChanges();
            }
        }
    }
}
