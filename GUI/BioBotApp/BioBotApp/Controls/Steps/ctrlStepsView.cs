using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Steps;
using BioBotApp.Controls.Parameter_controls;
using BioBotApp.Controls.Steps.Parameter_controls;
using BioBotApp.DataSets;
using BioBotApp.Controls.Option.Options;

namespace BioBotApp.Controls.Steps
{
    public partial class ctrlStepsView : UserControl
    {
        //Node types
        //dev
        private const String PROTOCOL_TYPE = "Protocol";
        private const String STEP_TYPE = "Step";

        //Context menu for the Protocol add type
        private ContextMenuStrip _contextMenuAutoFill;
        ToolStripItem _protocolToolStripItem;
        ToolStripItem _stepToolStripItem;
        //List that contains protocol types
        List<String> _protocolAddType = new List<string>(new String[] { PROTOCOL_TYPE, STEP_TYPE });

        //Project's dataset
        DataSets.dsModuleStructure3 _dsModuleStructure;
        //Project's module_type binding source
        BindingSource _bsModuleType;

        public ctrlStepsView()
        {
            InitializeComponent();
            CreateContextMenuStrip();
        }

        public void initControl(DataSets.dsModuleStructure3 dsModuleStructure, BindingSource bsModuleType)
        {
            _dsModuleStructure = dsModuleStructure;
            _bsModuleType = bsModuleType;
            _bsModuleType.CurrentChanged += _bsModuleType_CurrentChanged;
            initTree();
        }

        public void initTree()
        {
            tlvSteps.Nodes.Clear();
            Boolean add = false;
            foreach(DataSets.dsModuleStructure3.dtStepCompositeRow stepCompositeRow in _dsModuleStructure.dtStepComposite)
            {
                add = true;
                if (stepCompositeRow == null)
                {
                    add = false;
                }

                if(!stepCompositeRow.Isfk_step_parent_idNull())
                {
                    add = false;
                }
                if (add)
                {
                    addNodes(stepCompositeRow, null);
                }
            }
            
        }

        public void addNodes(DataSets.dsModuleStructure3.dtStepCompositeRow row, TreeNode parentNode)
        {
            TreeNode treeNode = new StepCompositeNode(row);
            DataSets.dsModuleStructure3.dtModuleRow module = getSelectedModuleRow();

            if(row.dtModuleRow.fk_module_type == module.fk_module_type)
            {
                if (parentNode == null)
                {
                    tlvSteps.Nodes.Add(treeNode);
                }
                else
                {
                    parentNode.Nodes.Add(treeNode);
                }

                foreach (DataSets.dsModuleStructure3.dtStepCompositeRow childRows in row.GetdtStepCompositeRows())
                {
                    addNodes(childRows, treeNode);
                }

                foreach (DataSets.dsModuleStructure3.dtStepLeafRow stepLeafRow in row.GetdtStepLeafRows())
                {
                    TreeNode stepLeafNode = new StepLeafNode(stepLeafRow, _dsModuleStructure.dtActionValue);
                    treeNode.Nodes.Add(stepLeafNode);
                }
            }
        }

        void _bsModuleType_CurrentChanged(object sender, EventArgs e)
        {
            initTree();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.ContextMenuStrip = _contextMenuAutoFill;
            btnAdd.ContextMenuStrip.Show(btnAdd, new System.Drawing.Point(0, btnAdd.Height));
        }

        private void CreateContextMenuStrip()
        {
            _contextMenuAutoFill = new ContextMenuStrip();
            _stepToolStripItem = _contextMenuAutoFill.Items.Add(STEP_TYPE);
            _protocolToolStripItem = _contextMenuAutoFill.Items.Add(PROTOCOL_TYPE);


            foreach (ToolStripMenuItem mItem in _contextMenuAutoFill.Items)
            {
                mItem.Click += new System.EventHandler(this.AutoFillToolStripMenuItem_Click);
            }
        }

        private void AutoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String protocolType = ((ToolStripMenuItem)sender).Text;
            //dialog result for adding new node to treeview
            DialogResult dialogResultAddNode = DialogResult.Cancel;
            frmNewProtocol frmProtocolAdd;
            frmNewStep _frmNewStep;
            TreeNode treeNode = new TreeNode();


            switch (protocolType)
            {
                case PROTOCOL_TYPE:

                    frmProtocolAdd = new frmNewProtocol();

                    dialogResultAddNode = frmProtocolAdd.ShowDialog();
                    if (dialogResultAddNode == DialogResult.OK)
                    {
                        //treeNodeText = frmProtocolAdd.getStepName();
                        DataSets.dsModuleStructure3.dtStepCompositeRow compositeRow = _dsModuleStructure.dtStepComposite.NewdtStepCompositeRow();
                        DataSets.dsModuleStructure3.dtModuleRow module = getSelectedModuleRow();
                        if (module == null)
                        {
                            return;
                        }

                        if (module.pk_id.Length == 0)
                        {
                            return;
                        }

                        compositeRow.fk_module_id = module.pk_id;
                        compositeRow.description = frmProtocolAdd.getStepName();
                        
                        if(tlvSteps.SelectedNode != null)
                        {
                            if(tlvSteps.SelectedNode is StepCompositeNode)
                            {
                                StepCompositeNode stepCompositeNode = tlvSteps.SelectedNode as StepCompositeNode;
                                compositeRow.fk_step_parent_id = stepCompositeNode.getStepCompositeRow().pk_id;
                            }
                        }

                        _dsModuleStructure.dtStepComposite.AdddtStepCompositeRow(compositeRow);

                        updateRow(compositeRow);

                        treeNode = new Steps.Parameter_controls.StepCompositeNode(compositeRow);
                    }

                    break;
                case STEP_TYPE:

                    DataSets.dsModuleStructure3.dtModuleRow moduleRow = getSelectedModuleRow();
                    DataSets.dsModuleStructure3.dtStepCompositeRow c = _dsModuleStructure.dtStepComposite.NewdtStepCompositeRow();


                    if (moduleRow == null)
                    {
                        break;
                    }

                    c.fk_module_id = moduleRow.pk_id;
                    //c.fk

                    String headerTitle = moduleRow.pk_id.ToString();

                    _frmNewStep = new frmNewStep(_dsModuleStructure, moduleRow);

                    dialogResultAddNode = _frmNewStep.ShowDialog();
                    if (dialogResultAddNode.Equals(DialogResult.OK))
                    {
                        if (tlvSteps.SelectedNode is StepCompositeNode)
                        {
                            StepCompositeNode stepCompositeNode = tlvSteps.SelectedNode as StepCompositeNode;
                            DataSets.dsModuleStructure3.dtStepLeafRow stepLeafRow = _dsModuleStructure.dtStepLeaf.NewdtStepLeafRow();
                            stepLeafRow.fk_step_composite = stepCompositeNode.getStepCompositeRow().pk_id;
                            stepLeafRow.description = _frmNewStep.getStepDescription();

                            _dsModuleStructure.dtStepLeaf.AdddtStepLeafRow(stepLeafRow);

                            updateRow(stepLeafRow);

                            treeNode = new StepLeafNode(stepLeafRow, _dsModuleStructure.dtActionValue);

                            Dictionary<dsModuleStructure3.dtModuleTypeActionTypeRow, ctrlCommand> command = _frmNewStep.getActionValues();
                            foreach(KeyValuePair<dsModuleStructure3.dtModuleTypeActionTypeRow, ctrlCommand> kvp in command)
                            {

                                Dictionary<dsModuleStructure3.dtActionTypeRow, namedInputTextBox> actionTypeInputBoxDict = kvp.Value.getActionTypesValues();

                                foreach(KeyValuePair<dsModuleStructure3.dtActionTypeRow, namedInputTextBox> kvpActionType in actionTypeInputBoxDict)
                                {
                                    if(kvpActionType.Value.getInputTextValue().Length != 0)
                                    {
                                        DataSets.dsModuleStructure3.dtActionValueRow actionValue = _dsModuleStructure.dtActionValue.NewdtActionValueRow();
                                        actionValue.fk_action_type = kvpActionType.Key.pk_id;
                                        actionValue.fk_action_value_type = kvp.Key.dtActionValueTypeRow.pk_id;
                                        actionValue.fk_step_leaf_id = stepLeafRow.pk_id;
                                        actionValue.description = kvpActionType.Value.getInputTextValue();
                                        _dsModuleStructure.dtActionValue.AdddtActionValueRow(actionValue);
                                        updateRow(actionValue);
                                    }
                                }
                            }
                        }
                    }

                    break;
                default:
                    break;
            }

            if (dialogResultAddNode.Equals(DialogResult.OK))
            {
                if (tlvSteps.SelectedNode != null)
                {
                    tlvSteps.SelectedNode.Nodes.Add(treeNode);
                }
                else
                {
                    tlvSteps.Nodes.Add(treeNode);
                }
            }
        }

        public void setSelectedModule(DataSets.dsModuleStructure3.dtModuleTypeRow moduleTypeRow, DataSets.dsModuleStructure3.dtActionTypeDataTable dtActionType)
        {
            btnAdd.Enabled = (!String.IsNullOrEmpty(moduleTypeRow.description) && dtActionType.Rows.Count > 0);
            btnDelete.Enabled = (!String.IsNullOrEmpty(moduleTypeRow.description) && dtActionType.Rows.Count > 0);
            //_contextMenuAutoFill.Items[STEP_TYPE].Enabled = (!String.IsNullOrEmpty(moduleTypeRow.Description) && dtActionType.Rows.Count > 0);
        }

        public DataSets.dsModuleStructure3.dtModuleRow getSelectedModuleRow()
        {
            if (_bsModuleType.Current == null)
            {
                return null;
            }
            DataRowView rowView = _bsModuleType.Current as DataRowView;
            DataSets.dsModuleStructure3.dtModuleRow moduleRow = rowView.Row
                as DataSets.dsModuleStructure3.dtModuleRow;

            return moduleRow;
        }

        private void tlvSteps_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is StepCompositeNode)
            {
                _protocolToolStripItem.Enabled = true;
                _stepToolStripItem.Enabled = true;
            }
            else if (e.Node is StepLeafNode)
            {
                _protocolToolStripItem.Enabled = false;
                _stepToolStripItem.Enabled = false;
            }
            else
            {
                throw new Exception("Wrong node type in steps treelist !");
            }
        }

        public void updateRow(DataSets.dsModuleStructure3.dtStepCompositeRow updateRow)
        {
            try
            {
                taStepComposite.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid step composite row, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _dsModuleStructure.RejectChanges();
            }
        }
        public void updateRow(DataSets.dsModuleStructure3.dtActionValueRow updateRow)
        {
            try
            {
                taActionValue.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid step composite row, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _dsModuleStructure.RejectChanges();
            }
        }
        public void updateRow(DataSets.dsModuleStructure3.dtStepLeafRow updateRow)
        {
            try
            {
                taStepLeaf.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid step composite row, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _dsModuleStructure.RejectChanges();
            }
        }

        private void tlvSteps_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            if(tlvSteps.SelectedNode == null)
            {
                return;
            }
            tlvSteps.DoDragDrop(tlvSteps.SelectedNode, DragDropEffects.Move);
            */
        }

        private void tlvSteps_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tlvSteps_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tlvSteps_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
