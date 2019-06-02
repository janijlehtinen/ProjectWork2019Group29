/*
 * Created by nxtSTUDIO.
 * User: dmidro
 * Date: 9/30/2018
 * Time: 3:12 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OrderConsole = new HMI.Main.Symbols.ProductOrder.sDefault();
			this.ButtonConsole = new HMI.Main.Symbols.ConsoleHMI.sDefault();
			this.sDefault1 = new HMI.Main.Symbols.StartPauseResetButtons.sDefault();
			this.DockConfirmationButton = new HMI.Main.Symbols.ConfirmationButton.sDefault();
			this.FailureHMI = new HMI.Main.Symbols.FailScenarioHMI.sDefault();
			this.ButtonConsole_1 = new HMI.Main.Symbols.ConsoleHMI.sDefault();
			this.FailureHMI_1 = new HMI.Main.Symbols.FailScenarioHMI.sDefault();
			this.failure1HMI = new HMI.Main.Symbols.fail_scenarios1.sDefault();
			// 
			// OrderConsole
			// 
			this.OrderConsole.BeginInit();
			this.OrderConsole.AngleIgnore = false;
			this.OrderConsole.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 20D, 22D);
			this.OrderConsole.Name = "OrderConsole";
			this.OrderConsole.SecurityToken = ((uint)(4294967295u));
			this.OrderConsole.TagName = "EAEA2FD7FE161725";
			this.OrderConsole.EndInit();
			// 
			// ButtonConsole
			// 
			this.ButtonConsole.BeginInit();
			this.ButtonConsole.AngleIgnore = false;
			this.ButtonConsole.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 616D, 364D);
			this.ButtonConsole.Name = "ButtonConsole";
			this.ButtonConsole.SecurityToken = ((uint)(4294967295u));
			this.ButtonConsole.TagName = "4511C8DC04CC8598";
			this.ButtonConsole.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.AngleIgnore = false;
			this.sDefault1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 591D, 398D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "4511C8DC04CC8598.FB1";
			this.sDefault1.EndInit();
			// 
			// DockConfirmationButton
			// 
			this.DockConfirmationButton.BeginInit();
			this.DockConfirmationButton.AngleIgnore = false;
			this.DockConfirmationButton.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 615D, 178D);
			this.DockConfirmationButton.Name = "DockConfirmationButton";
			this.DockConfirmationButton.SecurityToken = ((uint)(4294967295u));
			this.DockConfirmationButton.TagName = "4C6CA4A0B97F3D2D";
			this.DockConfirmationButton.EndInit();
			// 
			// FailureHMI
			// 
			this.FailureHMI.BeginInit();
			this.FailureHMI.AngleIgnore = false;
			this.FailureHMI.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 150D, 525D);
			this.FailureHMI.Name = "FailureHMI";
			this.FailureHMI.SecurityToken = ((uint)(4294967295u));
			this.FailureHMI.TagName = "D5E7DAAF597238E4";
			this.FailureHMI.EndInit();
			// 
			// ButtonConsole_1
			// 
			this.ButtonConsole_1.BeginInit();
			this.ButtonConsole_1.AngleIgnore = false;
			this.ButtonConsole_1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 230D, 532D);
			this.ButtonConsole_1.Name = "ButtonConsole_1";
			this.ButtonConsole_1.SecurityToken = ((uint)(4294967295u));
			this.ButtonConsole_1.TagName = "4511C8DC04CC8598";
			this.ButtonConsole_1.EndInit();
			// 
			// FailureHMI_1
			// 
			this.FailureHMI_1.BeginInit();
			this.FailureHMI_1.AngleIgnore = false;
			this.FailureHMI_1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 127D, 508D);
			this.FailureHMI_1.Name = "FailureHMI_1";
			this.FailureHMI_1.SecurityToken = ((uint)(4294967295u));
			this.FailureHMI_1.TagName = "D5E7DAAF597238E4";
			this.FailureHMI_1.EndInit();
			// 
			// failure1HMI
			// 
			this.failure1HMI.BeginInit();
			this.failure1HMI.AngleIgnore = false;
			this.failure1HMI.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 61D, 403D);
			this.failure1HMI.Name = "failure1HMI";
			this.failure1HMI.SecurityToken = ((uint)(4294967295u));
			this.failure1HMI.TagName = "A23B00BC1CF9115A";
			this.failure1HMI.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(919D)), ((float)(627D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.OrderConsole,
									this.ButtonConsole,
									this.sDefault1,
									this.DockConfirmationButton,
									this.FailureHMI,
									this.ButtonConsole_1,
									this.FailureHMI_1,
									this.failure1HMI});
			this.Size = new System.Drawing.Size(919, 627);
		}
		private HMI.Main.Symbols.fail_scenarios1.sDefault failure1HMI;
		private HMI.Main.Symbols.FailScenarioHMI.sDefault FailureHMI_1;
		private HMI.Main.Symbols.ConsoleHMI.sDefault ButtonConsole_1;
		private HMI.Main.Symbols.FailScenarioHMI.sDefault FailureHMI;
		private HMI.Main.Symbols.ConfirmationButton.sDefault DockConfirmationButton;
		private HMI.Main.Symbols.StartPauseResetButtons.sDefault sDefault1;
		private HMI.Main.Symbols.ConsoleHMI.sDefault ButtonConsole;
		private HMI.Main.Symbols.ProductOrder.sDefault OrderConsole;
		#endregion
	}
}
