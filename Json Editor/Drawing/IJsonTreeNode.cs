﻿using System;
using System.Windows.Forms;
namespace ZTn.Json.Editor.Drawing
{
    interface IJsonTreeNode
    {
        /// <summary>
        /// To be called whenever the node is collapsing
        /// </summary>
        void AfterCollapse();

        /// <summary>
        /// To be called whenever the node is expanding
        /// </summary>
        void AfterExpand();

        /// <summary>
        /// To be called whenever the value of the json text is changed
        /// </summary>
        TreeNode AfterJsonTextChange(string newJson);
    }
}
