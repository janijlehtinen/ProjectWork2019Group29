/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/12/2016
 * Time: 10:14 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #StartPauseResetButtons_HMI;

namespace HMI.Main.Symbols.StartPauseResetButtons
{

  public class INIDEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public INIDEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_StartIn(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? StartIn
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_PauseIn(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? PauseIn
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ResetIn(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ResetIn
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.StartPauseResetButtons
{

  public class INIDOEventArgs : System.EventArgs
  {
    public INIDOEventArgs()
    {
    }
    private System.Boolean? StartOut_field = null;
    public System.Boolean? StartOut
    {
       get { return StartOut_field; }
       set { StartOut_field = value; }
    }
    private System.Boolean? PauseOut_field = null;
    public System.Boolean? PauseOut
    {
       get { return PauseOut_field; }
       set { PauseOut_field = value; }
    }
    private System.Boolean? ResetOut_field = null;
    public System.Boolean? ResetOut
    {
       get { return ResetOut_field; }
       set { ResetOut_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.StartPauseResetButtons
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.StartPauseResetButtons.INIDEventArgs> INID_Fired;

    protected override void OnEndInit()
    {
      if (INID_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (INID_Fired != null)
          {
            try
            {
              INID_Fired(this, new HMI.Main.Symbols.StartPauseResetButtons.INIDEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","INID_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_INIDO(System.Boolean StartOut, System.Boolean PauseOut, System.Boolean ResetOut)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {StartOut, PauseOut, ResetOut});
    }
    public bool FireEvent_INIDO(HMI.Main.Symbols.StartPauseResetButtons.INIDOEventArgs ea)
    {
      object[] _values_ = new object[3];
      if (ea.StartOut.HasValue) _values_[0] = ea.StartOut.Value;
      if (ea.PauseOut.HasValue) _values_[1] = ea.PauseOut.Value;
      if (ea.ResetOut.HasValue) _values_[2] = ea.ResetOut.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_INIDO(System.Boolean StartOut, bool ignore_StartOut, System.Boolean PauseOut, bool ignore_PauseOut, System.Boolean ResetOut, bool ignore_ResetOut)
    {
      object[] _values_ = new object[3];
      if (!ignore_StartOut) _values_[0] = StartOut;
      if (!ignore_PauseOut) _values_[1] = PauseOut;
      if (!ignore_ResetOut) _values_[2] = ResetOut;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #StartPauseResetButtons_HMI;

#endregion Definitions;
