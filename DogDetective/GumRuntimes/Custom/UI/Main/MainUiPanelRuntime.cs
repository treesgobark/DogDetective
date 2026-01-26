using System;
using System.Diagnostics;
using FlatRedBall.Audio;
using Gum.Wireframe;
using Microsoft.Xna.Framework.Audio;

namespace DogDetective.GumRuntimes.Custom.UI.Main;

public partial class MainUiPanelRuntime
{
    partial void CustomInitialize()
    {
    }

    public void InitializeMenuButtons(GameScreenGumRuntime gumScreen)
    {
        MapButton.Click   += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.Map;
        CluesButton.Click += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.Clues;
        DogsButton.Click  += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.Dogs;
    }
}
