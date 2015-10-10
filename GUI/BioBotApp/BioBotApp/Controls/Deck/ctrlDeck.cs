using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Option.Options;

namespace BioBotApp.Controls.Deck
{
    public partial class ctrlDeck : UserControl
    {
        private int[] angle;

        public ctrlDeck()
        {
            InitializeComponent();
        }
        public void initDeck(DataSets.dsModuleStructure3 dsModuleStructure, BindingSource bsModule)
        {
            this.dsModuleStructure31 = dsModuleStructure;
            this.bs1=bsModule;
            bsModule.DataSource = this.dsModuleStructure31;

            this.bs1.DataMember = "dtModule";
            this.bs1.DataSource = this.dsModuleStructure31;

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string entry = e.Data.GetData(DataFormats.Text).ToString();
            abstractDialog dialog = new abstractDialog("New Module" + entry, "Type Info");
            namedInputTextBox xCoord = new namedInputTextBox("X :  ");
            namedInputTextBox yCoord = new namedInputTextBox("Y :  ");
            ComboBox rotation = new ComboBox();
            angle = new int[] { 0, 90, 180, 270 };
            rotation.DataSource = angle;
            rotation.Text="Rotation :  ";
            rotation.DropDownStyle = ComboBoxStyle.DropDown;
            dialog.addNamedInputTextBox(xCoord);
            dialog.addNamedInputTextBox(yCoord);
            dialog.addControl(rotation);

            dialog.ShowDialog();

            //if(e.Data.GetData(typeof(DataSets.dsModuleStructure3.dtModuleRow)))
            //{
                
            //}

            //if (dialog.DialogResult.Equals(DialogResult.OK))
            //{
            //    DataSets.dsModuleStructure3.dtModuleRow row;

            //    row = dsModuleStructure31.dtModule.NewdtModuleRow();
            //    row.description = xCoord.getInputTextValue();
            //    row.description = yCoord.getInputTextValue();
            //    row.description = rotation.getInputTextValue();
            //    dsModuleStructure31.dtModule.AdddtModuleRow(row);
            //    updateRow(row);
            //}
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {


            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

            string entry = e.Data.GetData(DataFormats.Text).ToString();
            abstractDialog dialog = new abstractDialog("New Module" + entry, "Type Info");
            namedInputTextBox xCoord = new namedInputTextBox("X :  ");
            namedInputTextBox yCoord = new namedInputTextBox("Y :  ");

            ComboBox rotation = new ComboBox();
            angle = new int[] { 0, 90, 180, 270 };
            rotation.DataSource = angle;
            rotation.Text = "Rotation :  ";
            rotation.DropDownStyle = ComboBoxStyle.DropDown;
            dialog.addNamedInputTextBox(xCoord);
            dialog.addNamedInputTextBox(yCoord);
            dialog.addControl(rotation);

            dialog.ShowDialog();
        }
    }
}
