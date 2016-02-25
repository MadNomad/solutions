/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.02.2016
 * Time: 9:59
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of BattleUserControl.
    /// </summary>
    public partial class BattleUserControl : BaseUserConrol
    {
        BattlePresenter Transport;
        public BattleUserControl()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            Transport = new BattlePresenter(this);
        }
        
    }
}
