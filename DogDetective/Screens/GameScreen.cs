using System.Linq;
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

        if (InputManager.Keyboard.KeyPushed(Keys.H))
        {
            GumScreen.MainUiPanelInstance.DogsButton.Visible = !GumScreen.MainUiPanelInstance.DogsButton.Visible;
        }

        if (InputManager.Keyboard.KeyPushed(Keys.J))
        {
            GumScreen.MainUiPanelInstance.DogsBackButton.Visible = !GumScreen.MainUiPanelInstance.DogsBackButton.Visible;
        }

        IWindow? window = Cursor.Main.WindowOver;
        switch (ActiveDebugger)
        {
            case 1:
                Debugger.CommandLineWrite($"{window}: {window?.Visible}, {window?.X}, {window?.Y}");
                break;
            case 2:
                Debugger.CommandLineWrite(
                    $"[{GumScreen.MainUiPanelInstance.MapButton.GetAbsoluteWidth()}, {GumScreen.MainUiPanelInstance.MapButton.GetAbsoluteHeight()}], "             +
                    $"[{GumScreen.MainUiPanelInstance.MapBackButton.GetAbsoluteWidth()}, {GumScreen.MainUiPanelInstance.MapBackButton.GetAbsoluteHeight()}], "     +
                    $"[{GumScreen.MainUiPanelInstance.CluesButton.GetAbsoluteWidth()}, {GumScreen.MainUiPanelInstance.CluesButton.GetAbsoluteHeight()}], "         +
                    $"[{GumScreen.MainUiPanelInstance.CluesBackButton.GetAbsoluteWidth()}, {GumScreen.MainUiPanelInstance.CluesBackButton.GetAbsoluteHeight()}], " +
                    $"[{GumScreen.MainUiPanelInstance.DogsButton.GetAbsoluteWidth()}, {GumScreen.MainUiPanelInstance.DogsButton.GetAbsoluteHeight()}], "           +
                    $"[{GumScreen.MainUiPanelInstance.DogsBackButton.GetAbsoluteWidth()}, {GumScreen.MainUiPanelInstance.DogsBackButton.GetAbsoluteHeight()}], "   +
                    $"");
                break;
            case 3:
                Debugger.CommandLineWrite($"{GumScreen.MainUiPanelInstance.MapButton.Visible}, "       +
                                          $"{GumScreen.MainUiPanelInstance.MapBackButton.Visible}, "   +
                                          $"{GumScreen.MainUiPanelInstance.CluesButton.Visible}, "     +
                                          $"{GumScreen.MainUiPanelInstance.CluesBackButton.Visible}, " +
                                          $"{GumScreen.MainUiPanelInstance.DogsButton.Visible}, "      +
                                          $"{GumScreen.MainUiPanelInstance.DogsBackButton.Visible}, "  +
                                          $"");
                break;
        }
    }

    private void CustomDestroy()
    {
            
    }

    private static void CustomLoadStaticContent(string contentManagerName)
    {
            
    }
}