using EZ_Builder;
using EZ_Builder.UCForms;

namespace Telepresence.Control {

  /// <summary>
  /// This is a basic control to showcase the capabilities of ez-builder in remote controlling an OhmniLabs Telepresence Robot
  /// </summary>
  public partial class MainForm : FormPluginMaster {

    private static readonly byte _MOVEMENT_STOP = 0x00;
    private static readonly byte _MOVEMENT_FORWARD = 0x01;
    private static readonly byte _MOVEMENT_REVERSE = 0x02;
    private static readonly byte _MOVEMENT_RIGHT = 0x03;
    private static readonly byte _MOVEMENT_LEFT = 0x04;

    public MainForm() {

      InitializeComponent();

      EZBManager.MovementManager.OnMovement2 += MovementManager_OnMovement2;
    }

    private void MovementManager_OnMovement2(MovementManager.MovementDirectionEnum direction, byte speedLeft, byte speedRight) {
      
      // Intercept and forward movement commands
      if (direction == MovementManager.MovementDirectionEnum.Stop)
        EZBManager.PrimaryEZB.SendCommandData(0, 0x00, _MOVEMENT_STOP);
      else if (direction == MovementManager.MovementDirectionEnum.Forward)
        EZBManager.EZBs[0].SendCommandData(0, 0x00, _MOVEMENT_FORWARD, speedLeft, speedRight);
      else if (direction == MovementManager.MovementDirectionEnum.Left)
        EZBManager.EZBs[0].SendCommandData(0, 0x00, _MOVEMENT_LEFT, speedLeft, speedRight);
      else if (direction == MovementManager.MovementDirectionEnum.Right)
        EZBManager.EZBs[0].SendCommandData(0, 0x00, _MOVEMENT_RIGHT, speedLeft, speedRight);
      else if (direction == MovementManager.MovementDirectionEnum.Reverse)
        EZBManager.EZBs[0].SendCommandData(0, 0x00, _MOVEMENT_REVERSE, speedLeft, speedRight);
    }
  }
}
