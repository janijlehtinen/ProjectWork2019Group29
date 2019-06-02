/*
 * Created by nxtSTUDIO.
 * User: dmidro
 * Date: 9/23/2018
 * Time: 2:03 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ProductOrder
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
			this.listBox1 = new NxtControl.GuiFramework.ListBox();
			this.redButton = new NxtControl.GuiFramework.DrawnButton();
			this.greenButton = new NxtControl.GuiFramework.DrawnButton();
			this.clearButton = new NxtControl.GuiFramework.DrawnButton();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.groupBox1 = new NxtControl.GuiFramework.GroupBox();
			this.label1 = new NxtControl.GuiFramework.Label();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.drawnButton2 = new NxtControl.GuiFramework.DrawnButton();
			this.groupBox2 = new NxtControl.GuiFramework.GroupBox();
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(167, 36);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(177, 160);
			this.listBox1.TabIndex = 0;
			// 
			// redButton
			// 
			this.redButton.Bounds = new NxtControl.Drawing.RectF(((float)(35D)), ((float)(35D)), ((float)(120D)), ((float)(70D)));
			this.redButton.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.redButton.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.redButton.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.redButton.Name = "redButton";
			this.redButton.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.redButton.Radius = 4D;
			this.redButton.Text = "RED";
			this.redButton.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.redButton.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.redButton.Use3DEffect = false;
			this.redButton.Click += new System.EventHandler(this.RedButtonClick);
			// 
			// greenButton
			// 
			this.greenButton.Bounds = new NxtControl.Drawing.RectF(((float)(35D)), ((float)(130D)), ((float)(120D)), ((float)(70D)));
			this.greenButton.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.greenButton.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.greenButton.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.greenButton.Name = "greenButton";
			this.greenButton.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.greenButton.Radius = 4D;
			this.greenButton.Text = "GREEN";
			this.greenButton.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.greenButton.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.greenButton.Use3DEffect = false;
			this.greenButton.Click += new System.EventHandler(this.GreenButtonClick);
			// 
			// clearButton
			// 
			this.clearButton.Bounds = new NxtControl.Drawing.RectF(((float)(681D)), ((float)(84D)), ((float)(120D)), ((float)(70D)));
			this.clearButton.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.clearButton.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.clearButton.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.clearButton.Name = "clearButton";
			this.clearButton.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.clearButton.Radius = 4D;
			this.clearButton.Text = "CLEAR";
			this.clearButton.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.clearButton.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.clearButton.Use3DEffect = false;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(360D)), ((float)(35D)), ((float)(120D)), ((float)(70D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Reset orders";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			this.drawnButton1.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BeginInit();
			this.groupBox1.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(35D)), ((float)(216D)), ((float)(134D)));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Radius = 20D;
			this.groupBox1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.clearButton,
									this.label1});
			this.groupBox1.EndInit();
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(649D)), ((float)(51D)), ((float)(179D)), ((float)(25D)));
			this.label1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label1.Font = new NxtControl.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.Text = "Status OK";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(53D)), ((float)(238D)), ((float)(179D)), ((float)(25D)));
			this.label2.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label2.Font = new NxtControl.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// drawnButton2
			// 
			this.drawnButton2.Bounds = new NxtControl.Drawing.RectF(((float)(84D)), ((float)(275D)), ((float)(120D)), ((float)(70D)));
			this.drawnButton2.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton2.Enabled = false;
			this.drawnButton2.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton2.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton2.Name = "drawnButton2";
			this.drawnButton2.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton2.Radius = 4D;
			this.drawnButton2.Text = "OK";
			this.drawnButton2.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton2.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton2.Use3DEffect = false;
			this.drawnButton2.Click += new System.EventHandler(this.DrawnButton2Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BeginInit();
			this.groupBox2.Bounds = new NxtControl.Drawing.RectF(((float)(35D)), ((float)(220D)), ((float)(216D)), ((float)(134D)));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Radius = 20D;
			this.groupBox2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.label2,
									this.drawnButton2});
			this.groupBox2.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.listBox1,
									this.redButton,
									this.greenButton,
									this.drawnButton1,
									this.groupBox1,
									this.groupBox2});
			this.SymbolSize = new System.Drawing.Size(885, 400);
		}
		private NxtControl.GuiFramework.GroupBox groupBox2;
		private NxtControl.GuiFramework.DrawnButton drawnButton2;
		private NxtControl.GuiFramework.Label label2;
		private NxtControl.GuiFramework.GroupBox groupBox1;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.DrawnButton clearButton;
		private NxtControl.GuiFramework.DrawnButton greenButton;
		private NxtControl.GuiFramework.DrawnButton redButton;
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.ListBox listBox1;
		#endregion
	}
}
