/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/7/2016
 * Time: 2:36 AM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Pallet
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
		
		void Execute_11ValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    PalletPresent.Visible = true;
		  }
		  else {
		    PalletPresent.Visible = false;
		  }
		}
		
	}
}
