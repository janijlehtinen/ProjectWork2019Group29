/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/12/2016
 * Time: 10:14 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.StartPauseResetButtons
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
			this.Pause = new System.HMI.Symbols.Base.CheckButton();
			this.Start = new System.HMI.Symbols.Base.CheckButton();
			this.Reset = new System.HMI.Symbols.Base.CheckButton();
			this.RunningText = new NxtControl.GuiFramework.FreeText();
			this.PausedText = new NxtControl.GuiFramework.FreeText();
			this.ResetText = new NxtControl.GuiFramework.FreeText();
			this.StartIn = new System.HMI.Symbols.Base.Execute<bool>();
			this.PauseIn = new System.HMI.Symbols.Base.Execute<bool>();
			this.ResetIn = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// Pause
			// 
			this.Pause.BeginInit();
			this.Pause.AngleIgnore = false;
			this.Pause.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 2.4666666666666668D, 118D, 75D);
			this.Pause.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Pause.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Pause.FalseText = "PAUSE";
			this.Pause.Name = "Pause";
			this.Pause.TagName = "PauseOut";
			this.Pause.TextColorTrue = new NxtControl.Drawing.Color("AlarmCame");
			this.Pause.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Pause.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Pause.TrueText = "PAUSED";
			this.Pause.Value = false;
			this.Pause.EndInit();
			// 
			// Start
			// 
			this.Start.BeginInit();
			this.Start.AngleIgnore = false;
			this.Start.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 2.5D, 18D, 75D);
			this.Start.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Start.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Start.FalseText = "START";
			this.Start.Name = "Start";
			this.Start.TagName = "StartOut";
			this.Start.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Start.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Start.TrueText = "START";
			this.Start.Value = false;
			this.Start.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StartValueChanged);
			this.Start.EndInit();
			// 
			// Reset
			// 
			this.Reset.BeginInit();
			this.Reset.AngleIgnore = false;
			this.Reset.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 2.5333333333333332D, 218D, 75D);
			this.Reset.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Reset.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Reset.FalseText = "RESET";
			this.Reset.Name = "Reset";
			this.Reset.TagName = "ResetOut";
			this.Reset.TextColorTrue = new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10)));
			this.Reset.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Reset.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Reset.TrueText = "RESET";
			this.Reset.Value = false;
			this.Reset.EndInit();
			// 
			// RunningText
			// 
			this.RunningText.Color = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.RunningText.Font = new NxtControl.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
			this.RunningText.Location = new NxtControl.Drawing.PointF(72D, 13D);
			this.RunningText.Name = "RunningText";
			this.RunningText.Text = "RUNNING";
			this.RunningText.Visible = false;
			// 
			// PausedText
			// 
			this.PausedText.Color = new NxtControl.Drawing.Color("AlarmCame");
			this.PausedText.Font = new NxtControl.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
			this.PausedText.Location = new NxtControl.Drawing.PointF(82D, 13D);
			this.PausedText.Name = "PausedText";
			this.PausedText.Text = "PAUSED";
			this.PausedText.Visible = false;
			// 
			// ResetText
			// 
			this.ResetText.Color = new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10)));
			this.ResetText.Font = new NxtControl.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
			this.ResetText.Location = new NxtControl.Drawing.PointF(95D, 13D);
			this.ResetText.Name = "ResetText";
			this.ResetText.Text = "RESET";
			this.ResetText.Visible = false;
			// 
			// StartIn
			// 
			this.StartIn.BeginInit();
			this.StartIn.AngleIgnore = false;
			this.StartIn.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 110D, 329D);
			this.StartIn.IsOnlyInput = true;
			this.StartIn.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StartIn.Name = "StartIn";
			this.StartIn.Size = new NxtControl.Drawing.SizeF(1D, 1D);
			this.StartIn.TagName = "StartIn";
			this.StartIn.Value = false;
			this.StartIn.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StartInValueChanged);
			this.StartIn.EndInit();
			// 
			// PauseIn
			// 
			this.PauseIn.BeginInit();
			this.PauseIn.AngleIgnore = false;
			this.PauseIn.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 62D, 267D);
			this.PauseIn.IsOnlyInput = true;
			this.PauseIn.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PauseIn.Name = "PauseIn";
			this.PauseIn.Size = new NxtControl.Drawing.SizeF(1D, 1D);
			this.PauseIn.TagName = "PauseIn";
			this.PauseIn.Value = false;
			this.PauseIn.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PauseInValueChanged);
			this.PauseIn.EndInit();
			// 
			// ResetIn
			// 
			this.ResetIn.BeginInit();
			this.ResetIn.AngleIgnore = false;
			this.ResetIn.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 57D, 309D);
			this.ResetIn.IsOnlyInput = true;
			this.ResetIn.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ResetIn.Name = "ResetIn";
			this.ResetIn.Size = new NxtControl.Drawing.SizeF(1D, 1D);
			this.ResetIn.TagName = "ResetIn";
			this.ResetIn.Value = false;
			this.ResetIn.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ResetInValueChanged);
			this.ResetIn.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Pause,
									this.Start,
									this.Reset,
									this.RunningText,
									this.PausedText,
									this.ResetText,
									this.StartIn,
									this.PauseIn,
									this.ResetIn});
			this.SymbolSize = new System.Drawing.Size(317, 167);
		}
		private System.HMI.Symbols.Base.Execute<bool> ResetIn;
		private System.HMI.Symbols.Base.Execute<bool> PauseIn;
		private System.HMI.Symbols.Base.Execute<bool> StartIn;
		private NxtControl.GuiFramework.FreeText ResetText;
		private NxtControl.GuiFramework.FreeText PausedText;
		private NxtControl.GuiFramework.FreeText RunningText;
		private System.HMI.Symbols.Base.CheckButton Reset;
		private System.HMI.Symbols.Base.CheckButton Start;
		private System.HMI.Symbols.Base.CheckButton Pause;
		#endregion
	}
}
