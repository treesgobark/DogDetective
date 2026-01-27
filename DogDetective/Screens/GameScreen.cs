using FlatRedBall.Gui;
using FlatRedBall.Input;
using Microsoft.Xna.Framework.Input;
using Debugger = FlatRedBall.Debugging.Debugger;

namespace DogDetective.Screens;

public partial class GameScreen
{
    public int ActiveDebugger { get; set; } = 0;
    
    private void CustomInitialize()
    {
    }

    private void CustomActivity(bool firstTimeCalled)
    {
        if (InputManager.Keyboard.KeyPushed(Keys.Space))
        {
            Forms.DanteThoughtsDialogBoxInstance.DialogBoxInstance.ShowAsync(
                GumScreen.DanteThoughtsDialogBoxInstance.DialogBoxInstance.TextInstance.Text);
        }

        if (InputManager.Keyboard.KeyPushed(Keys.Up))
        {
            ActiveDebugger++;
        }
        else if (InputManager.Keyboard.KeyPushed(Keys.Down))
        {
            ActiveDebugger--;
        }

        if (ActiveDebugger == 0)
        {
            Debugger.CommandLineWrite(Cursor.Main.WindowOver);
        }
        else if (ActiveDebugger == 1)
        {
            Debugger.CommandLineWrite($"{GumScreen.MainUiPanelInstance.DogsButton.GetAbsoluteWidth()}, {GumScreen.MainUiPanelInstance.DogsButton.GetAbsoluteHeight()}");
        }
    }

    private void CustomDestroy()
    {
            
    }

    private static void CustomLoadStaticContent(string contentManagerName)
    {
            
    }
}