/*
 * Created by nxtSTUDIO.
 * User: dmidro
 * Date: 10/5/2018
 * Time: 9:26 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ConfirmationButton
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
      this.REQ_Fired += REQ_Fired_EventHandler;
		}
		
		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.ConfirmationButton.REQEventArgs ea)
		{
			this.drawnButton1.Enabled = true;
			this.label1.Text = ea.message.ToString();
			
		}
		
		void DrawnButton1Click(object sender, EventArgs e)
		{
		  this.FireEvent_CNF();
		  this.label1.Text = "";
		  this.drawnButton1.Enabled = false;
		}
	}
}
