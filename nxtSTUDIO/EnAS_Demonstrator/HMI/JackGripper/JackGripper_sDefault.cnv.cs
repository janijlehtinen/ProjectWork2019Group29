/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/17/2016
 * Time: 11:17 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.JackGripper
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void MachineStateValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value == false)
			  Executing.Visible = false;
			else if (((bool)e.Value == true) && (WIP.Visible == true))
			  Executing.Visible = true;
			
		}
			
		void ExecuteValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value == true && (MachineState.Visible == true)) {
		    Executing.Visible = true;
		    WIP.Visible = true;
		  }  
			else if (((bool)e.Value == false) && (MachineState.Visible == true)) {
		    Executing.Visible = false;
		    WIP.Visible = false;
		  }
		}
	}
}
