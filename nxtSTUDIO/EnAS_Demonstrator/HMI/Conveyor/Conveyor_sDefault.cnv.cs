/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 9/30/2016
 * Time: 2:41 AM
 * 
 */

using System;
using System.Drawing;
//using NxtStudio.Symbols;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Conveyor
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
	  
		void SensorValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value == true) {
		    sensor1.Visible = true;
		  }
		  else {
		    sensor1.Visible = false;
		  }
		}
			
		void ConvOnValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    conveyorOn.Visible = true;
		    conveyorStop.Visible = false;
		  }
		  else {
		    if ((conveyorGoingStop.Visible == true) && (sensor1.Visible == false)){
		      conveyorStop.Visible = true;
		      conveyorGoingStop.Visible = false;
		    }
		    conveyorOn.Visible = false;
		  }
		}
		
		void StopSignalValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    if ((conveyorOn.Visible == true) || (sensor1.Visible == true) || (executing.Visible == true)){
		      conveyorGoingStop.Visible = true;
		    }
		    conveyorStop.Visible = true;
		  }
		  else {
		    conveyorGoingStop.Visible = false;
		    conveyorStop.Visible = false;
		  }
		}
		
		void PauseSignalValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value == true) {
		    ConveyorPause.Visible = true;
		  }
		  else {
		    ConveyorPause.Visible = false;
		  }
		}
		
	  void ExecutingSignalValueChanged(object sender, ValueChangedEventArgs e)
		{
	    if ((bool)e.Value == true) {
		    executing.Visible = true;
		  }
		  else {
		    executing.Visible = false;
		  }
		}
		
		
		/*
		void ReadyValueChanged(object sender, ValueChangedEventArgs e)
		{
		}		
		void ConvOnValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    if (SystemRunning.Visible == true) {
		      conveyorOn.Visible = true;
		    }
		    conveyorOff.Visible = false;
		  }
		  else {
		    conveyorOff.Visible = true;
		  }
		}*/
		/*
		void MachineStateValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if (((bool)e.Value == false) && (WIP.Visible == true))
		    conveyorOff.Visible = true;
		  else if (((bool)e.Value == true) && (WIP.Visible == true))
		    conveyorOff.Visible = false;
		}
		
		void ConvOnValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true && (WIP.Visible == false)) {
		    conveyorOn.Visible = true;
		    conveyorOff.Visible = false;
		  }
		  else if (((bool)e.Value == false) && (WIP.Visible == false)) {
		    if (conveyorGoingStop.Visible == false)
		      conveyorOff.Visible = true;
		    else
		      conveyorGoingStop.Visible = false;
		  }
		}
		
		void StopSignalValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    if (conveyorOn.Visible == true){
		      conveyorGoingStop.Visible = true;
		    }
		    conveyorStop.Visible = true;
		  }
		  else {
		    conveyorGoingStop.Visible = false;
		    conveyorStop.Visible = false;
		  }			
		}
		void MachineStateValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value == true)
		    SystemRunning.Visible = true;
		  else
		    SystemRunning.Visible = false;			
		}
		
		void StopSignalValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    if (conveyorOn.Visible == true){
		      conveyorGoingStop.Visible = true;
		    }
		    conveyorStop.Visible = true;
		  }
		  else {
		    conveyorGoingStop.Visible = false;
		    conveyorStop.Visible = false;
		  }		
		}
		*/
		/*
		void ConvOnValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    if (SectionExecuting.Visible == false) {
		      conveyorOn.Visible = true;
		    }
		    conveyorOff.Visible = false;
		  }
		  else {
		     // conveyorOff.Visible = true;
		       if (conveyorGoingStop.Visible == true) {
		        conveyorGoingStop.Visible = false;
		        conveyorOn.Visible = false;
		        conveyorStop.Visible = true;
		       }
		      else
		        conveyorOff.Visible = true;
		  }
		}
		
		void StopSignalValueChanged(object sender, ValueChangedEventArgs e)
		{
		  if ((bool)e.Value == true) {
		    conveyorStop.Visible = true;
		    conveyorOff.Visible = false;
		    if (SectionExecuting.Visible == true) {
		      conveyorGoingStop.Visible = true;
		    }
		  }
		  else {
		    conveyorGoingStop.Visible = false;
		    conveyorStop.Visible = false;
		    conveyorOff.Visible = true;
		  }					
		}
		
		void ExecutingValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)e.Value == true)
		    SectionExecuting.Visible = true;
		  else
		    SectionExecuting.Visible = false;		
		}
		*/
		
	}
}
