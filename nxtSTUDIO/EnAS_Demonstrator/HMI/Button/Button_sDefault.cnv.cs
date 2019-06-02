/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/6/2016
 * Time: 2:43 AM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Button
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
		
		
		void StopSignalClick(object sender, EventArgs e)
		{
			StopSignal.Value = true;
		}
		
		void PausedValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if((bool)e.Value == true)
		    StopSignal.Enabled = false;
		  else
		    StopSignal.Enabled = true;
		}
	}
}
