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
    public partial class optionModuleTypeActionType : UserControl
    {
        public optionModuleTypeActionType()
        {
            InitializeComponent();
        }

        public optionModuleTypeActionType(DataSets.dsModuleStructure3 dsModuleStructure)
            : this()
        {
            this.dsModuleStructureGUI = dsModuleStructure;

            bsModuleType.DataSource = dsModuleStructureGUI.dtModuleType;
            bsActionType.DataSource = dsModuleStructureGUI.dtActionType;
            bsModuleTypeActionType.DataSource = dsModuleStructureGUI.dtModuleTypeActionType;
            bsActionValueType.DataSource = dsModuleStructureGUI.dtActionValueType;

            bsModuleTypeActionType.MoveFirst();
            updateActionTypeGrid();
            bsModuleType.CurrentChanged += bsModuleType_CurrentChanged;   
        }

        void bsModuleType_CurrentChanged(object sender, EventArgs e)
        {
            updateActionTypeGrid();
        }

        public void updateActionTypeGrid()
        {
            if (bsActionType.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure3.dtModuleTypeRow row = getSelectedModuleTypeRow();

            if (row == null)
            {
                dsModuleStructureGUI.dtModuleTypeActionType.DefaultView.RowFilter = String.Empty;
                return;
            }

            dsModuleStructureGUI.dtModuleTypeActionType.DefaultView.RowFilter = "fk_module_type_id = " + row.pk_id;
        }



        private void crudOptionsActionType_AddClickHandler(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure3.dtModuleTypeRow moduleTypeSelectedRow = getSelectedModuleTypeRow();

            if (moduleTypeSelectedRow == null)
            {
                return;
            }

            abstractDialog dialog = new abstractDialog("Module type action type",
                "Add action for : " + moduleTypeSelectedRow.description);
            ComboBox cbActionType = new ComboBox();
            ComboBox cbActionValueTupe = new ComboBox();

            cbActionType.DataSource = bsActionType;
            cbActionType.DisplayMember = "description";

            cbActionValueTupe.DataSource = bsActionValueType;
            cbActionValueTupe.DisplayMember = "description";
            
            dialog.addControl(cbActionType);
            dialog.addControl(cbActionValueTupe);
            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                createModuleTypeActionTypeRow();
            }
        }

        public void createModuleTypeActionTypeRow()
        {
            DataSets.dsModuleStructure3.dtModuleTypeActionTypeRow row = dsModuleStructureGUI.dtModuleTypeActionType.NewdtModuleTypeActionTypeRow();
            DataSets.dsModuleStructure3.dtActionTypeRow actionTypeRow = getSelectedActionTypeRow();
            DataSets.dsModuleStructure3.dtModuleTypeRow moduleTypeRow = getSelectedModuleTypeRow();
            DataSets.dsModuleStructure3.dtActionValueTypeRow actionValueTypeRow = getSelectedActionValueTypeRow();

            if (actionTypeRow == null || moduleTypeRow == null || actionValueTypeRow == null)
            {
                return;
            }

            row.fk_action_type_id = actionTypeRow.pk_id;
            row.fk_module_type_id = moduleTypeRow.pk_id;
            row.fk_action_value_type_id = actionValueTypeRow.pk_id;
            dsModuleStructureGUI.dtModuleTypeActionType.AdddtModuleTypeActionTypeRow(row);
            dsModuleStructureGUI.dtActionType.DefaultView.RowFilter = String.Empty;
            updateRow(row);
        }

        private void crudOptionsActionType_DeleteClickHandler(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure3.dtModuleTypeActionTypeRow row = getSelectedModuleTypeActionTypeRow();
            DataSets.dsModuleStructure3.dtModuleTypeRow moduleTypeRow = getSelectedModuleTypeRow();
            DataSets.dsModuleStructure3.dtActionTypeRow actionTypeRow = getSelectedActionTypeRow();

            if (row == null || moduleTypeRow == null || actionTypeRow == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                  "Delete : " + actionTypeRow.description + " for " + moduleTypeRow.description,
                  "Delete module type action type ?",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                row.Delete();
                updateRow(row);
            }
        }

        #region Get selected binding sources row
        public DataSets.dsModuleStructure3.dtActionTypeRow getSelectedActionTypeRow()
        {
            DataSets.dsModuleStructure3.dtActionTypeRow actionTypeRow;

            if (bsActionType.Current == null)
            {
                return null;
            }
           
            DataRowView dataRowViewActionType = bsActionType.Current as DataRowView;
            actionTypeRow = dataRowViewActionType.Row as DataSets.dsModuleStructure3.dtActionTypeRow;
            return actionTypeRow;
        }

        public DataSets.dsModuleStructure3.dtModuleTypeRow getSelectedModuleTypeRow()
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

        public DataSets.dsModuleStructure3.dtModuleTypeActionTypeRow getSelectedModuleTypeActionTypeRow()
        {
            DataSets.dsModuleStructure3.dtModuleTypeActionTypeRow row;

            if (bsModuleTypeActionType.Current == null)
            {
                return null;
            }

            DataRowView rowView = bsModuleTypeActionType.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure3.dtModuleTypeActionTypeRow;
            return row;
        }

        public DataSets.dsModuleStructure3.dtActionValueTypeRow getSelectedActionValueTypeRow()
        {
            DataSets.dsModuleStructure3.dtActionValueTypeRow row;

            if (bsActionValueType.Current == null)
            {
                return null;
            }

            DataRowView rowView = bsActionValueType.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure3.dtActionValueTypeRow;
            return row;
        }

        #endregion

        public void updateRow(DataSets.dsModuleStructure3.dtModuleTypeActionTypeRow updateRow)
        {
            try
            {
                taModuleTypeActionType.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action type for the selected module type, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsModuleStructureGUI.RejectChanges();
            }
        }


    }
}
