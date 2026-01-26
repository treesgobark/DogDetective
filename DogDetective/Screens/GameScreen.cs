using System;
using System.Diagnostics;
using DogDetective.GumRuntimes;
using FlatRedBall.Audio;
using FlatRedBall.Input;
using Gum.Wireframe;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;

namespace DogDetective.Screens;

public partial class GameScreen
{
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
    }

    private void CustomDestroy()
    {
            
    }

    private static void CustomLoadStaticContent(string contentManagerName)
    {
            
    }
}