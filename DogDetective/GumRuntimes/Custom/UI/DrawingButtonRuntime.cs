using System;
using FlatRedBall.Audio;
using FlatRedBall.Forms.Controls;
using FlatRedBall.Gui;
using Gum.DataTypes.Variables;

namespace DogDetective.GumRuntimes.Custom.UI;

public partial class DrawingButtonRuntime
{
    partial void CustomInitialize()
    {
        StateSaveCategory buttonCategory = Categories[Button.ButtonCategoryName];
        StateSave highlightedState =
            buttonCategory.States.Find(item => item.Name == FrameworkElement.HighlightedStateName);
        highlightedState.Apply += () =>
        {
            if (Cursor.Main.WindowOver == this)
            {
                CurrentButtonCategoryState = ButtonCategory.Highlighted;
                var instance = GlobalContent.HoverDrawing.CreateInstance();
                instance.Pitch = (Random.Shared.NextSingle() * 2 - 1) * 0.05f;
                AudioManager.Play(instance);
            }
        };
    }
}