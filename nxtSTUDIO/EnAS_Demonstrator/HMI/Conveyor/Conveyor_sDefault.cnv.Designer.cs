/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 9/30/2016
 * Time: 2:41 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Conveyor
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
			this.conveyorOff = new NxtControl.GuiFramework.Rectangle();
			this.conveyorOn = new NxtControl.GuiFramework.Rectangle();
			this.conveyorStop = new NxtControl.GuiFramework.Rectangle();
			this.conveyorGoingStop = new NxtControl.GuiFramework.Rectangle();
			this.sensor1 = new NxtControl.GuiFramework.Rectangle();
			this.ConvOn = new System.HMI.Symbols.Base.Execute<bool>();
			this.StopSignal = new System.HMI.Symbols.Base.Execute<bool>();
			this.Sensor = new System.HMI.Symbols.Base.Execute<bool>();
			this.ConveyorPause = new NxtControl.GuiFramework.Rectangle();
			this.PauseSignal = new System.HMI.Symbols.Base.Execute<bool>();
			this.executing = new NxtControl.GuiFramework.Rectangle();
			this.ExecutingSignal = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// conveyorOff
			// 
			this.conveyorOff.Bounds = new NxtControl.Drawing.RectF(((float)(120)), ((float)(130)), ((float)(383)), ((float)(34)));
			this.conveyorOff.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Grey50"));
			this.conveyorOff.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.conveyorOff.Name = "conveyorOff";
			// 
			// conveyorOn
			// 
			this.conveyorOn.Bounds = new NxtControl.Drawing.RectF(((float)(120)), ((float)(130)), ((float)(383)), ((float)(34)));
			this.conveyorOn.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.conveyorOn.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.conveyorOn.Name = "conveyorOn";
			this.conveyorOn.Visible = false;
			// 
			// conveyorStop
			// 
			this.conveyorStop.Bounds = new NxtControl.Drawing.RectF(((float)(120)), ((float)(130)), ((float)(383)), ((float)(34)));
			this.conveyorStop.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Red"));
			this.conveyorStop.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.conveyorStop.Name = "conveyorStop";
			this.conveyorStop.Visible = false;
			// 
			// conveyorGoingStop
			// 
			this.conveyorGoingStop.Bounds = new NxtControl.Drawing.RectF(((float)(120)), ((float)(130)), ((float)(383)), ((float)(34)));
			this.conveyorGoingStop.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Yellow"));
			this.conveyorGoingStop.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.conveyorGoingStop.Name = "conveyorGoingStop";
			this.conveyorGoingStop.Visible = false;
			// 
			// sensor1
			// 
			this.sensor1.Bounds = new NxtControl.Drawing.RectF(((float)(129)), ((float)(137)), ((float)(16)), ((float)(15)));
			this.sensor1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.sensor1.Name = "sensor1";
			this.sensor1.Visible = false;
			// 
			// ConvOn
			// 
			this.ConvOn.BeginInit();
			this.ConvOn.AngleIgnore = false;
			this.ConvOn.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 198, 192);
			this.ConvOn.IsOnlyInput = true;
			this.ConvOn.Name = "ConvOn";
			this.ConvOn.TagName = "ConvOn";
			this.ConvOn.Value = false;
			this.ConvOn.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ConvOnValueChanged);
			this.ConvOn.EndInit();
			// 
			// StopSignal
			// 
			this.StopSignal.BeginInit();
			this.StopSignal.AngleIgnore = false;
			this.StopSignal.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 230, 223);
			this.StopSignal.IsOnlyInput = true;
			this.StopSignal.Name = "StopSignal";
			this.StopSignal.TagName = "StopSignal";
			this.StopSignal.Value = false;
			this.StopSignal.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StopSignalValueChanged);
			this.StopSignal.EndInit();
			// 
			// Sensor
			// 
			this.Sensor.BeginInit();
			this.Sensor.AngleIgnore = false;
			this.Sensor.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 389, 206);
			this.Sensor.IsOnlyInput = true;
			this.Sensor.Name = "Sensor";
			this.Sensor.TagName = "Sensor";
			this.Sensor.Value = false;
			this.Sensor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SensorValueChanged);
			this.Sensor.EndInit();
			// 
			// ConveyorPause
			// 
			this.ConveyorPause.Bounds = new NxtControl.Drawing.RectF(((float)(120)), ((float)(130)), ((float)(383)), ((float)(34)));
			this.ConveyorPause.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("DarkGrey"));
			this.ConveyorPause.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ConveyorPause.Name = "ConveyorPause";
			this.ConveyorPause.Visible = false;
			// 
			// PauseSignal
			// 
			this.PauseSignal.BeginInit();
			this.PauseSignal.AngleIgnore = false;
			this.PauseSignal.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 163, 306);
			this.PauseSignal.IsOnlyInput = true;
			this.PauseSignal.Name = "PauseSignal";
			this.PauseSignal.TagName = "PauseSignal";
			this.PauseSignal.Value = false;
			this.PauseSignal.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PauseSignalValueChanged);
			this.PauseSignal.EndInit();
			// 
			// executing
			// 
			this.executing.Bounds = new NxtControl.Drawing.RectF(((float)(161)), ((float)(140)), ((float)(17)), ((float)(18)));
			this.executing.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.executing.Name = "executing";
			// 
			// ExecutingSignal
			// 
			this.ExecutingSignal.BeginInit();
			this.ExecutingSignal.AngleIgnore = false;
			this.ExecutingSignal.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 154, 270);
			this.ExecutingSignal.IsOnlyInput = true;
			this.ExecutingSignal.Name = "ExecutingSignal";
			this.ExecutingSignal.TagName = "ExecutingSignal";
			this.ExecutingSignal.Value = false;
			this.ExecutingSignal.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecutingSignalValueChanged);
			this.ExecutingSignal.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.executing,
									this.sensor1,
									this.conveyorOff,
									this.conveyorOn,
									this.ConvOn,
									this.StopSignal,
									this.conveyorStop,
									this.Sensor,
									this.conveyorGoingStop,
									this.ConveyorPause,
									this.PauseSignal,
									this.ExecutingSignal});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.Execute<bool> ExecutingSignal;
		private NxtControl.GuiFramework.Rectangle executing;
		private System.HMI.Symbols.Base.Execute<bool> PauseSignal;
		private NxtControl.GuiFramework.Rectangle ConveyorPause;
		private System.HMI.Symbols.Base.Execute<bool> Sensor;
		private NxtControl.GuiFramework.Rectangle sensor1;
		private System.HMI.Symbols.Base.Execute<bool> StopSignal;
		private System.HMI.Symbols.Base.Execute<bool> ConvOn;
		private NxtControl.GuiFramework.Rectangle conveyorGoingStop;
		private NxtControl.GuiFramework.Rectangle conveyorStop;
		private NxtControl.GuiFramework.Rectangle conveyorOn;
		private NxtControl.GuiFramework.Rectangle conveyorOff;
		#endregion
	}
}
