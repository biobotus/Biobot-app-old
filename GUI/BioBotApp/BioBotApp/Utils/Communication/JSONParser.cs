using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication
{
    class JSONParser
    {
        //Back of old jsonparser
        /*
        #region JSON converter Section
        public String getJSON()
        {
            String jsonValue = String.Empty;
            foreach (TreeNodeProtocolType treeNodeChilds in tlvSteps.Nodes)
            {
                if (treeNodeChilds.getNodeType().Equals(PROTOCOL_TYPE))
                {
                    jsonValue += getNodeStepValues(treeNodeChilds);
                }

            }

            return jsonValue;
        }

        public String getNodeStepValues(TreeNodeProtocolType treeNode)
        {
            String jsonValue = String.Empty;
            foreach (TreeNodeProtocolType treeNodeChilds in treeNode.Nodes)
            {
                if (treeNodeChilds.getNodeType().Equals(PROTOCOL_TYPE))
                {
                    jsonValue += getNodeStepValues(treeNodeChilds);
                }
                else
                {
                    jsonValue += treeNodeChilds.getStepValue().description;
                }

            }

            return jsonValue;
        }
        #endregion
         * */
    }
}
