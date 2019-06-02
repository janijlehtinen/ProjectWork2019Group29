/*
 * Created by nxtSTUDIO.
 * User: erik
 * Date: 5/14/2019
 * Time: 9:34 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Fail_scenarios
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
		
	
		

		
		void StartValueChanged(object sender, ValueChangedEventArgs e)
		{
			
		}
	}
}
