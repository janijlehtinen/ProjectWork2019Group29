/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/6/2016
 * Time: 2:43 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Button
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
			this.StopSignal = new System.HMI.Symbols.Base.CheckButton();
			this.Paused = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// StopSignal
			// 
			this.StopSignal.BeginInit();
			this.StopSignal.AngleIgnore = false;
			this.StopSignal.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 219, 169);
			this.StopSignal.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.StopSignal.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.StopSignal.FalseText = "UPDATE";
			this.StopSignal.Name = "StopSignal";
			this.StopSignal.TagName = "StopSignal";
			this.StopSignal.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.StopSignal.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.StopSignal.TrueText = "UPDATING";
			this.StopSignal.Value = false;
			this.StopSignal.Click += new System.EventHandler(this.StopSignalClick);
			this.StopSignal.EndInit();
			// 
			// Paused
			// 
			this.Paused.BeginInit();
			this.Paused.AngleIgnore = false;
			this.Paused.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 280, 243);
			this.Paused.IsOnlyInput = true;
			this.Paused.Name = "Paused";
			this.Paused.TagName = "Paused";
			this.Paused.Value = false;
			this.Paused.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PausedValueChanged);
			this.Paused.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.StopSignal,
									this.Paused});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.Execute<bool> Paused;
		private System.HMI.Symbols.Base.CheckButton StopSignal;
		#endregion
	}
}
