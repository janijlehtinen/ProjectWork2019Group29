/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/17/2016
 * Time: 11:17 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.JackGripper
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Executing = new NxtControl.GuiFramework.Rectangle();
			this.Idle = new NxtControl.GuiFramework.Rectangle();
			this.MachineState = new System.HMI.Symbols.Base.Execute<bool>();
			this.WIP = new NxtControl.GuiFramework.Rectangle();
			this.execute = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// Executing
			// 
			this.Executing.Bounds = new NxtControl.Drawing.RectF(((float)(200)), ((float)(130)), ((float)(50)), ((float)(50)));
			this.Executing.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.Executing.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Executing.Name = "Executing";
			this.Executing.Visible = false;
			// 
			// Idle
			// 
			this.Idle.Bounds = new NxtControl.Drawing.RectF(((float)(200)), ((float)(130)), ((float)(50)), ((float)(50)));
			this.Idle.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))));
			this.Idle.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Idle.Name = "Idle";
			// 
			// MachineState
			// 
			this.MachineState.BeginInit();
			this.MachineState.AngleIgnore = false;
			this.MachineState.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 180, 292);
			this.MachineState.IsOnlyInput = true;
			this.MachineState.Name = "MachineState";
			this.MachineState.TagName = "MachineState";
			this.MachineState.Value = false;
			this.MachineState.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MachineStateValueChanged);
			this.MachineState.EndInit();
			// 
			// WIP
			// 
			this.WIP.Bounds = new NxtControl.Drawing.RectF(((float)(200)), ((float)(130)), ((float)(20)), ((float)(21)));
			this.WIP.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.WIP.Name = "WIP";
			this.WIP.Visible = false;
			// 
			// execute
			// 
			this.execute.BeginInit();
			this.execute.AngleIgnore = false;
			this.execute.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 183, 219);
			this.execute.IsOnlyInput = true;
			this.execute.Name = "execute";
			this.execute.TagName = "Executing";
			this.execute.Value = false;
			this.execute.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecuteValueChanged);
			this.execute.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.WIP,
									this.Idle,
									this.Executing,
									this.MachineState,
									this.execute});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private NxtControl.GuiFramework.Rectangle WIP;
		private System.HMI.Symbols.Base.Execute<bool> execute;
		private NxtControl.GuiFramework.Rectangle Executing;
		private System.HMI.Symbols.Base.Execute<bool> MachineState;
		private NxtControl.GuiFramework.Rectangle Idle;
		#endregion
	}
}
