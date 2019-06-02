/*
 * Created by nxtSTUDIO.
 * User: dmidro
 * Date: 9/23/2018
 * Time: 2:03 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ProductOrder
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
      this.READY_Fired += READY_Fired_EventHandler;
      this.CHECK_J1_Fired += CHECK_J1_Fired_EventHandler;
      this.CHECK_J2_Fired += CHECK_J2_Fired_EventHandler;
		}
		
		
		void ClearButtonClick(object sender, EventArgs e)
		{
			this.label1.Text = "Status OK";
			this.FireEvent_CLEAR();
		}
		
		void RedButtonClick(object sender, EventArgs e)
		{
			listBox1.Items.Add("RED");
			if(this.listBox1.Items.Count == 1) CheckOrderList(); //if the item is first in the list, check list and execute order
		  //this.FireEvent_PRODUCE_RED();
		}
		
		void GreenButtonClick(object sender, EventArgs e)
		{
			this.listBox1.Items.Add("GREEN");
			if(this.listBox1.Items.Count == 1) CheckOrderList(); //if the item is first in the list, check list and execute order
		  //this.FireEvent_PRODUCE_GREEN();
		}
		
		void CheckOrderList()
		{
		  if(this.listBox1.Items.Count > 0) {
		    if(this.listBox1.Items[0].ToString()=="GREEN") this.FireEvent_PRODUCE_GREEN();
		    else if(this.listBox1.Items[0].ToString()=="RED") this.FireEvent_PRODUCE_RED();
		  }
		}
		
		void READY_Fired_EventHandler(object sender, HMI.Main.Symbols.ProductOrder.READYEventArgs ea)
		{
		  label2.Text = this.listBox1.Items[0].ToString() + " ready";
		  if(this.listBox1.Items.Count > 0) this.listBox1.Items.RemoveAt(0);
		  drawnButton2.Enabled = true;
		}
		
		void DrawnButton1Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}
		
		void DrawnButton2Click(object sender, EventArgs e)
		{
			CheckOrderList();
			drawnButton2.Enabled = false;
			label2.Text = "";
		}
		
		void CHECK_J1_Fired_EventHandler(object sender, HMI.Main.Symbols.ProductOrder.CHECK_J1EventArgs ea)
		{
			this.label1.Text = "Check Machine!";
		}
		
		void CHECK_J2_Fired_EventHandler(object sender, HMI.Main.Symbols.ProductOrder.CHECK_J2EventArgs ea)
		{
			this.label1.Text = "Check Machine!";
		}
	}
}
