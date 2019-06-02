/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/7/2016
 * Time: 2:36 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Pallet
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
			this.PalletPresent = new NxtControl.GuiFramework.Rectangle();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// PalletPresent
			// 
			this.PalletPresent.Bounds = new NxtControl.Drawing.RectF(((float)(157)), ((float)(127)), ((float)(90)), ((float)(90)));
			this.PalletPresent.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212))));
			this.PalletPresent.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.PalletPresent.Name = "PalletPresent";
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.AngleIgnore = false;
			this.execute_11.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 210, 178);
			this.execute_11.IsOnlyInput = true;
			this.execute_11.Name = "execute_11";
			this.execute_11.TagName = "PalletPresent";
			this.execute_11.Value = false;
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Execute_11ValueChanged);
			this.execute_11.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.PalletPresent,
									this.execute_11});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.Execute<bool> execute_11;
		private NxtControl.GuiFramework.Rectangle PalletPresent;
		#endregion
	}
}
