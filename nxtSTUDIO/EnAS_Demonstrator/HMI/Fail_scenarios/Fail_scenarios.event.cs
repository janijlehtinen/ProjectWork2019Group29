/*
 * Created by nxtSTUDIO.
 * User: erik
 * Date: 5/14/2019
 * Time: 9:34 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Fail_scenarios_HMI;

namespace HMI.Main.Symbols.Fail_scenarios
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
    public bool Get_J1_IN(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? J1_IN
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_CONV1_IN(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? CONV1_IN
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.Fail_scenarios
{

  public class INIDOEventArgs : System.EventArgs
  {
    public INIDOEventArgs()
    {
    }
    private System.Boolean? J1_OUT_field = null;
    public System.Boolean? J1_OUT
    {
       get { return J1_OUT_field; }
       set { J1_OUT_field = value; }
    }
    private System.Boolean? CONV1_OUT_field = null;
    public System.Boolean? CONV1_OUT
    {
       get { return CONV1_OUT_field; }
       set { CONV1_OUT_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.Fail_scenarios
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.Fail_scenarios.INIDEventArgs> INID_Fired;

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
              INID_Fired(this, new HMI.Main.Symbols.Fail_scenarios.INIDEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_INIDO(System.Boolean J1_OUT, System.Boolean CONV1_OUT)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {J1_OUT, CONV1_OUT});
    }
    public bool FireEvent_INIDO(HMI.Main.Symbols.Fail_scenarios.INIDOEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.J1_OUT.HasValue) _values_[0] = ea.J1_OUT.Value;
      if (ea.CONV1_OUT.HasValue) _values_[1] = ea.CONV1_OUT.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_INIDO(System.Boolean J1_OUT, bool ignore_J1_OUT, System.Boolean CONV1_OUT, bool ignore_CONV1_OUT)
    {
      object[] _values_ = new object[2];
      if (!ignore_J1_OUT) _values_[0] = J1_OUT;
      if (!ignore_CONV1_OUT) _values_[1] = CONV1_OUT;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Fail_scenarios_HMI;

#endregion Definitions;
