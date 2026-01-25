using DogDetective.GumRuntimes;
using FlatRedBall.Input;

namespace DogDetective.Screens;

public partial class GameScreen
{
    private void CustomInitialize()
    {
        GumScreen.CurrentCurrentRoomState = GameScreenGumRuntime.CurrentRoom.MainEntrance;
    }

    private void CustomActivity(bool firstTimeCalled)
    {
        if (InputManager.Keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.Space))
        {
            Forms.DanteThoughtsDialogBoxInstance.DialogBoxInstance.ShowAsync(
                GumScreen.DanteThoughtsDialogBoxInstance.DialogBoxInstance.TextInstance.Text);
        }
    }

    private void CustomDestroy()
    {
            
    }

    private static void CustomLoadStaticContent(string contentManagerName)
    {
            
    }
}