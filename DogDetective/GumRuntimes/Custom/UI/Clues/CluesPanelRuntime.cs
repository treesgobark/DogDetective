using FlatRedBall.Audio;

namespace DogDetective.GumRuntimes.Custom.UI.Clues;

public partial class CluesPanelRuntime
{
    partial void CustomInitialize()
    {
        PropertyChanged += (sender, args) =>
        {
            if (args.PropertyName == nameof(CurrentActiveCluesPageState) && CurrentActiveCluesPageState is not null)
            {
                AudioManager.Play(GlobalContent.TurnPage);
            }

            PreviousActiveCluesPageState = CurrentActiveCluesPageState;
        };

        KnifeButton.Click        += _ => CurrentActiveCluesPageState = ActiveCluesPage.Knife;
        BloodstainsButton.Click  += _ => CurrentActiveCluesPageState = ActiveCluesPage.Bloodstain;
        BookButton.Click         += _ => CurrentActiveCluesPageState = ActiveCluesPage.Book;
        EnvelopeButton.Click     += _ => CurrentActiveCluesPageState = ActiveCluesPage.Envelope;
        FabricButton.Click       += _ => CurrentActiveCluesPageState = ActiveCluesPage.Fabric;
        FileButton.Click         += _ => CurrentActiveCluesPageState = ActiveCluesPage.File;
        FlowerButton.Click       += _ => CurrentActiveCluesPageState = ActiveCluesPage.Flower;
        FoxglovePageButton.Click += _ => CurrentActiveCluesPageState = ActiveCluesPage.FoxglovePage;
        GlassButton.Click        += _ => CurrentActiveCluesPageState = ActiveCluesPage.Glass;
        WoundButton.Click        += _ => CurrentActiveCluesPageState = ActiveCluesPage.Wound;
    }

    private ActiveCluesPage? PreviousActiveCluesPageState { get; set; }
}