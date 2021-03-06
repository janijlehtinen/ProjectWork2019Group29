/*
 * Created by nxtSTUDIO.
 * User: Aalto_IT
 * Date: 10/6/2016
 * Time: 2:43 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Button_HMI;

namespace HMI.Main.Symbols.Button
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
    public bool Get_Paused(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? Paused
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.Button
{

  public class INIDOEventArgs : System.EventArgs
  {
    public INIDOEventArgs()
    {
    }
    private System.Boolean? StopSignal_field = null;
    public System.Boolean? StopSignal
    {
       get { return StopSignal_field; }
       set { StopSignal_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.Button
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.Button.INIDEventArgs> INID_Fired;

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
              INID_Fired(this, new HMI.Main.Symbols.Button.INIDEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_INIDO(System.Boolean StopSignal)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {StopSignal});
    }
    public bool FireEvent_INIDO(HMI.Main.Symbols.Button.INIDOEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.StopSignal.HasValue) _values_[0] = ea.StopSignal.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_INIDO(System.Boolean StopSignal, bool ignore_StopSignal)
    {
      object[] _values_ = new object[1];
      if (!ignore_StopSignal) _values_[0] = StopSignal;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Button_HMI;

#endregion Definitions;
