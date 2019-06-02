/*
 * Created by nxtSTUDIO.
 * User: dmidro
 * Date: 10/5/2018
 * Time: 9:26 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ConfirmationButton
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
			this.groupBox1 = new NxtControl.GuiFramework.GroupBox();
			this.label1 = new NxtControl.GuiFramework.Label();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			// 
			// groupBox1
			// 
			this.groupBox1.BeginInit();
			this.groupBox1.Bounds = new NxtControl.Drawing.RectF(((float)(28D)), ((float)(15D)), ((float)(216D)), ((float)(134D)));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Radius = 20D;
			this.groupBox1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.drawnButton1,
									this.label1});
			this.groupBox1.EndInit();
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(27D)), ((float)(179D)), ((float)(25D)));
			this.label1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label1.Font = new NxtControl.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(75D)), ((float)(63D)), ((float)(120D)), ((float)(70D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Enabled = false;
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "OK";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			this.drawnButton1.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.groupBox1});
			this.SymbolSize = new System.Drawing.Size(481, 302);
		}
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.GroupBox groupBox1;
		#endregion
	}
}
