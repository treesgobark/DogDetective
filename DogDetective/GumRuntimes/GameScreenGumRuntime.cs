using System.Diagnostics;
using FlatRedBall.Audio;
using Microsoft.Xna.Framework.Audio;

namespace DogDetective.GumRuntimes;

public partial class GameScreenGumRuntime
{
    private ActiveMenu? PreviousMenuState { get; set; }
    
    partial void CustomInitialize()
    {
        MainUiPanelInstance.InitializeMenuButtons(this);
        
        MapPanelInstance.InitializeButtons(this);
        CluesPanelInstance.InitializeButtons(this);
        DogsPanelInstance.InitializeButtons(this);

        PropertyChanged += (sender, args) =>
        {
            if (args.PropertyName == "CurrentActiveMenuState" && CurrentActiveMenuState is not null)
            {
                SoundEffect sound = (PreviousMenuState, CurrentActiveMenuState) switch
                {
                    (ActiveMenu.None, not ActiveMenu.None)     => GlobalContent.OpenBook,
                    (not ActiveMenu.None, ActiveMenu.None)     => GlobalContent.CloseBook,
                    (not ActiveMenu.None, not ActiveMenu.None) => GlobalContent.TurnPage,
                    _                                          => throw new UnreachableException(),
                };
                AudioManager.Play(sound);
            }

            PreviousMenuState = CurrentActiveMenuState;
        };
    }
}