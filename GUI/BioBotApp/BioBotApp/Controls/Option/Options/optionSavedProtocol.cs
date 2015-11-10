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
    public partial class optionSavedProtocol : UserControl
    {
        private int index;

        public optionSavedProtocol()
        {
            InitializeComponent();
        }
        public optionSavedProtocol(DataSets.dsModuleStructure3 dsModuleStructure) : this()
        {
            this.dsModuleStructureGUI = dsModuleStructure;

            this.dtSavedProtocolBindingSource.DataSource = dsModuleStructureGUI;
            this.dataGridView1.DataSource = taSavedProtocol1.GetDataByDesc();
            this.dataGridView2.DataSource = taSavedProtocol1.GetData();
            bindingSource1.DataSource = dataGridView2.DataSource;
            this.bindingSource1.Filter = "description = null";
        }

        private void dtSavedProtocolBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            if (this.dataGridView1.CurrentCell == null)
            {
                this.bindingSource1.Filter = "description = null";
            }
            else
            {
                bindingSource1.Filter = "description  = '" + dataGridView1.CurrentCell.Value.ToString() + "'";
                dataGridView2.DataSource = bindingSource1;
            }

        }

        private void crudOptionsSavedProtocol_AddClickHandler(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure3.dtSavedProtocolRow ProtocolSavedRow = getSavedProtocolRow();
            if (ProtocolSavedRow == null)
            {
                return;
            }
            abstractDialog dialog = new abstractDialog( "New protocol", "Add new protocol");

            //ComboBox ProtocolID = new ComboBox();
            namedInputTextBox description = new namedInputTextBox("Protocol Name");

            //ProtocolID.DataSource = dsModuleStructureGUI.dtStepComposite;
            //ProtocolID.DisplayMember = "description";


            dialog.addNamedInputTextBox(description);
            //dialog.addControl(ProtocolID);
            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure3.dtSavedProtocolRow row;
                row = dsModuleStructureGUI.dtSavedProtocol.NewdtSavedProtocolRow();
                row.description = description.getInputTextValue();
                dsModuleStructureGUI.dtSavedProtocol.AdddtSavedProtocolRow(row);
                updateSavedProtocolRow(row);
            }
        }

        private void crudOptionsSavedProtocol_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure3.dtSavedProtocolRow row;
            row = getSavedProtocolRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete Step ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateSavedProtocolRow(row);
        }

        private void crudOptionsSavedProtocol_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Saved Protocols", "Modify");
            DataSets.dsModuleStructure3.dtSavedProtocolRow row = getSavedProtocolRow();

            if (row == null)
            {
                return;
            }

            namedInputTextBox description = new namedInputTextBox("Description", row.description);
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                row.description = description.getInputTextValue();
                updateSavedProtocolRow(row);
            }
        }

        private void crudOptionsSavedSteps_AddClickHandler(object sender, EventArgs e)
        {
            //DataSets.dsModuleStructure3.dtSavedProtocolRow ProtocolSavedRow = getSavedProtocolRow();
            //if (ProtocolSavedRow == null)
            //{
            //    return;
            //}
            abstractDialog dialog = new abstractDialog("New Step", "Add new Step to " + dataGridView1.CurrentCell.Value.ToString());

            //ComboBox ProtocolID = new ComboBox();
            namedComboBox ComboBoxStep = new namedComboBox("Step : ");
            //namedInputTextBox description = new namedInputTextBox("Protocol Name");

            //ProtocolID.DataSource = dsModuleStructureGUI.dtStepComposite;
            //ProtocolID.DisplayMember = "description";

            ComboBoxStep.Text = "Action Type";
            ComboBoxStep.getComboBox().DataSource = dsModuleStructureGUI.dtStepComposite;
            ComboBoxStep.getComboBox().ValueMember = "pk_id";
            ComboBoxStep.getComboBox().DisplayMember = "description";
           

            dialog.addControl(ComboBoxStep);
            //dialog.addControl(ProtocolID);
            dialog.ShowDialog();

            DataSets.dsModuleStructure3.dtStepCompositeRow StepCompositerow;
            DataRowView ActionCombo = ComboBoxStep.getComboBox().SelectedItem as DataRowView;
            StepCompositerow = ActionCombo.Row as DataSets.dsModuleStructure3.dtStepCompositeRow;

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {

                DataSets.dsModuleStructure3.dtSavedProtocolRow row;
                row = dsModuleStructureGUI.dtSavedProtocol.NewdtSavedProtocolRow();
                row.description = dataGridView1.CurrentCell.Value.ToString();
                row.fk_step_composite = StepCompositerow.pk_id;
                dsModuleStructureGUI.dtSavedProtocol.AdddtSavedProtocolRow(row);
                updateSavedProtocolRow(row);
                
            }
        }

        private void crudOptionsSavedSteps_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure3.dtSavedProtocolRow row;
            row = getSavedProtocolRow();

            DialogResult result = MessageBox.Show("Delete Step ID: " + row.fk_step_composite + " ?", "Delete Step ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateSavedProtocolRow(row);
        }

        private void crudOptionsSavedSteps_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Saved Steps", "Modify");
            DataSets.dsModuleStructure3.dtSavedProtocolRow row = getSavedProtocolRow();

            if (row == null)
            {
                return;
            }

            namedInputTextBox description = new namedInputTextBox("Description", row.description);
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                row.description = description.getInputTextValue();
                updateSavedProtocolRow(row);
            }
        }

        public DataSets.dsModuleStructure3.dtSavedProtocolRow getSavedProtocolRow()
        {
            DataSets.dsModuleStructure3.dtSavedProtocolRow row;

                if (dtSavedProtocolBindingSource.Current == null)
                {
                    return null;
                }
            
            DataRowView rowView = dtSavedProtocolBindingSource.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure3.dtSavedProtocolRow;
            return row;
        }

        public void updateSavedProtocolRow(DataSets.dsModuleStructure3.dtSavedProtocolRow updateRow)
        {
            try
            {
                taSavedProtocol1.Update(updateRow);
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
    

