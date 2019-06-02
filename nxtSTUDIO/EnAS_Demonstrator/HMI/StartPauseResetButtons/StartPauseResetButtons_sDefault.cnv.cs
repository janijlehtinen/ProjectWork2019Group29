/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/12/2016
 * Time: 10:14 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.StartPauseResetButtons
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
		
		
		
		
		void StartInValueChanged(object sender, ValueChangedEventArgs e)
		{
		  RunningText.Visible = (bool)e.Value;
		}
		
		void PauseInValueChanged(object sender, ValueChangedEventArgs e)
		{
  		  PausedText.Visible = (bool)e.Value;
		}
		
		void ResetInValueChanged(object sender, ValueChangedEventArgs e)
		{
    	  ResetText.Visible = (bool)e.Value;
		}
		
		void StartValueChanged(object sender, ValueChangedEventArgs e)
		{

		}
	}
}
