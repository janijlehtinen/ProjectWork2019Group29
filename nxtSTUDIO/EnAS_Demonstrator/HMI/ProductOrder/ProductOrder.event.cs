/*
 * Created by nxtSTUDIO.
 * User: dmidro
 * Date: 9/23/2018
 * Time: 2:03 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ProductOrder_HMI;

namespace HMI.Main.Symbols.ProductOrder
{

  public class CHECK_J1EventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CHECK_J1EventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class READYEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public READYEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

  public class CHECK_J2EventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public CHECK_J2EventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

}

namespace HMI.Main.Symbols.ProductOrder
{

  public class PRODUCE_REDEventArgs : System.EventArgs
  {
    public PRODUCE_REDEventArgs()
    {
    }

  }

  public class PRODUCE_GREENEventArgs : System.EventArgs
  {
    public PRODUCE_GREENEventArgs()
    {
    }

  }

  public class CLEAREventArgs : System.EventArgs
  {
    public CLEAREventArgs()
    {
    }

  }

}

namespace HMI.Main.Symbols.ProductOrder
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.ProductOrder.CHECK_J1EventArgs> CHECK_J1_Fired;

    private event EventHandler<HMI.Main.Symbols.ProductOrder.READYEventArgs> READY_Fired;

    private event EventHandler<HMI.Main.Symbols.ProductOrder.CHECK_J2EventArgs> CHECK_J2_Fired;

    protected override void OnEndInit()
    {
      if (CHECK_J1_Fired != null)
        AttachEventInput(0);
      if (READY_Fired != null)
        AttachEventInput(1);
      if (CHECK_J2_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (CHECK_J1_Fired != null)
          {
            try
            {
              CHECK_J1_Fired(this, new HMI.Main.Symbols.ProductOrder.CHECK_J1EventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CHECK_J1_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (READY_Fired != null)
          {
            try
            {
              READY_Fired(this, new HMI.Main.Symbols.ProductOrder.READYEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","READY_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (CHECK_J2_Fired != null)
          {
            try
            {
              CHECK_J2_Fired(this, new HMI.Main.Symbols.ProductOrder.CHECK_J2EventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","CHECK_J2_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_PRODUCE_RED()
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {});
    }
    public bool FireEvent_PRODUCE_RED(HMI.Main.Symbols.ProductOrder.PRODUCE_REDEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_PRODUCE_GREEN()
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {});
    }
    public bool FireEvent_PRODUCE_GREEN(HMI.Main.Symbols.ProductOrder.PRODUCE_GREENEventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CLEAR()
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {});
    }
    public bool FireEvent_CLEAR(HMI.Main.Symbols.ProductOrder.CLEAREventArgs ea)
    {
      object[] _values_ = new object[0];
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #ProductOrder_HMI;

#endregion Definitions;
