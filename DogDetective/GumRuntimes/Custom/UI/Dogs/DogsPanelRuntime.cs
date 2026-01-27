using FlatRedBall.Audio;

namespace DogDetective.GumRuntimes.Custom.UI.Dogs;

public partial class DogsPanelRuntime
{
    partial void CustomInitialize()
    {
        PropertyChanged += (sender, args) =>
        {
            if (args.PropertyName == nameof(CurrentActiveDogPageState) && CurrentActiveDogPageState is not null)
            {
                AudioManager.Play(GlobalContent.TurnPage);
            }

            // PreviousActiveCluesPageState = CurrentActiveDogPageState;
        };
    }
}