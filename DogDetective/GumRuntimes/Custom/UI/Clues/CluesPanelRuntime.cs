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

        KnifeButtonClick        += _ => CurrentActiveCluesPageState = ActiveCluesPage.Knife;
        BloodstainButtonClick   += _ => CurrentActiveCluesPageState = ActiveCluesPage.Bloodstain;
        BookButtonClick         += _ => CurrentActiveCluesPageState = ActiveCluesPage.Book;
        EnvelopeButtonClick     += _ => CurrentActiveCluesPageState = ActiveCluesPage.Envelope;
        FabricButtonClick       += _ => CurrentActiveCluesPageState = ActiveCluesPage.Fabric;
        FileButtonClick         += _ => CurrentActiveCluesPageState = ActiveCluesPage.File;
        FlowerButtonClick       += _ => CurrentActiveCluesPageState = ActiveCluesPage.Flower;
        FoxglovePageButtonClick += _ => CurrentActiveCluesPageState = ActiveCluesPage.FoxglovePage;
        GlassButtonClick        += _ => CurrentActiveCluesPageState = ActiveCluesPage.Glass;
        WoundButtonClick        += _ => CurrentActiveCluesPageState = ActiveCluesPage.Wound;
        
        BookBackButtonInstanceClick += _ => CurrentActiveCluesPageState = ActiveCluesPage.None;
    }

    private ActiveCluesPage? PreviousActiveCluesPageState { get; set; }
}