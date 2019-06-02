/*
 * Created by nxtSTUDIO.
 * User: erik
 * Date: 5/15/2019
 * Time: 5:55 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #fail_scenarios1_HMI;

namespace HMI.Main.Symbols.fail_scenarios1
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace HMI.Main.Symbols.fail_scenarios1
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
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

namespace HMI.Main.Symbols.fail_scenarios1
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.fail_scenarios1.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new HMI.Main.Symbols.fail_scenarios1.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF(System.Boolean J1_OUT, System.Boolean CONV1_OUT)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {J1_OUT, CONV1_OUT});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.fail_scenarios1.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.J1_OUT.HasValue) _values_[0] = ea.J1_OUT.Value;
      if (ea.CONV1_OUT.HasValue) _values_[1] = ea.CONV1_OUT.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean J1_OUT, bool ignore_J1_OUT, System.Boolean CONV1_OUT, bool ignore_CONV1_OUT)
    {
      object[] _values_ = new object[2];
      if (!ignore_J1_OUT) _values_[0] = J1_OUT;
      if (!ignore_CONV1_OUT) _values_[1] = CONV1_OUT;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #fail_scenarios1_HMI;

#endregion Definitions;
