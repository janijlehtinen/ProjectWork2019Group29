/*
 * Created by nxtSTUDIO.
 * User: erik
 * Date: 5/14/2019
 * Time: 9:34 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Fail_scenarios
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
			this.trend1 = new NxtControl.GuiFramework.Trend();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.J1_OUT = new System.HMI.Symbols.Base.CheckButton();
			this.CONV1_OUT = new System.HMI.Symbols.Base.CheckButton();
			this.checkButton1 = new System.HMI.Symbols.Base.CheckButton();
			this.checkButton2 = new System.HMI.Symbols.Base.CheckButton();
			((System.ComponentModel.ISupportInitialize)(this.trend1)).BeginInit();
			// 
			// trend1
			// 
			this.trend1.Location = new System.Drawing.Point(65, 121);
			this.trend1.Name = "trend1";
			this.trend1.ParentSymbol = this;
			this.trend1.Size = new System.Drawing.Size(3, 3);
			this.trend1.TabIndex = 0;
			this.trend1.TimeScale = new NxtControl.GuiFramework.TrendTimeScale(true, "HH:mm", false, true);
			this.trend1.TimeSpan = System.TimeSpan.Parse("00:05:00");
			this.trend1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(this.trend1, NxtControl.GuiFramework.TrendValueScaleType.Left, true, "#,##0.##", 0D, 100D, true, "", 0D, 100D, false, false, true));
			this.trend1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(this.trend1, NxtControl.GuiFramework.TrendValueScaleType.Right, true, "#,##0.##", 0D, 100D, false, "", 0D, 100D, false, false, true));
			this.trend1.ZoomPercentX = 10D;
			this.trend1.ZoomPercentY = 10D;
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("DevAnalogPv");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(54D, 5D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Jack1 malfunction";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("DevAnalogPv");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(22D, 95D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Conveyor1 malfunction";
			// 
			// J1_OUT
			// 
			this.J1_OUT.BeginInit();
			this.J1_OUT.AngleIgnore = false;
			this.J1_OUT.DesignTransformation = new NxtControl.Drawing.Matrix(0.775D, 0D, 0D, 1.9D, 118D, 35D);
			this.J1_OUT.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.J1_OUT.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.J1_OUT.FalseText = "START";
			this.J1_OUT.Name = "J1_OUT";
			this.J1_OUT.TagName = "J1_OUT";
			this.J1_OUT.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.J1_OUT.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.J1_OUT.TrueText = "START";
			this.J1_OUT.Value = false;
			this.J1_OUT.EndInit();
			// 
			// CONV1_OUT
			// 
			this.CONV1_OUT.BeginInit();
			this.CONV1_OUT.AngleIgnore = false;
			this.CONV1_OUT.DesignTransformation = new NxtControl.Drawing.Matrix(0.725D, 0D, 0D, 2.0666666666666664D, 118D, 129D);
			this.CONV1_OUT.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.CONV1_OUT.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.CONV1_OUT.FalseText = "ON";
			this.CONV1_OUT.Name = "CONV1_OUT";
			this.CONV1_OUT.TagName = "CONV1_OUT";
			this.CONV1_OUT.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.CONV1_OUT.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.CONV1_OUT.TrueText = "OFF";
			this.CONV1_OUT.Value = false;
			this.CONV1_OUT.EndInit();
			// 
			// checkButton1
			// 
			this.checkButton1.BeginInit();
			this.checkButton1.AngleIgnore = false;
			this.checkButton1.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 190D, 143D);
			this.checkButton1.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.Name = "checkButton1";
			this.checkButton1.TagName = "CONV1_OUT";
			this.checkButton1.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.checkButton1.Value = false;
			this.checkButton1.EndInit();
			// 
			// checkButton2
			// 
			this.checkButton2.BeginInit();
			this.checkButton2.AngleIgnore = false;
			this.checkButton2.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 198D, 47D);
			this.checkButton2.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.checkButton2.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.checkButton2.Name = "checkButton2";
			this.checkButton2.TagName = "J1_OUT";
			this.checkButton2.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.checkButton2.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.checkButton2.Value = false;
			this.checkButton2.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.trend1,
									this.freeText1,
									this.freeText2,
									this.J1_OUT,
									this.CONV1_OUT,
									this.checkButton1,
									this.checkButton2});
			this.SymbolSize = new System.Drawing.Size(300, 200);
			((System.ComponentModel.ISupportInitialize)(this.trend1)).EndInit();
		}
		private System.HMI.Symbols.Base.CheckButton checkButton2;
		private System.HMI.Symbols.Base.CheckButton checkButton1;
		private System.HMI.Symbols.Base.CheckButton CONV1_OUT;
		private System.HMI.Symbols.Base.CheckButton J1_OUT;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Trend trend1;
		#endregion
	}
}
