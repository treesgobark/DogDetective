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
        };

        DogsPageInstance.ArthurButtonClick   += _ => CurrentActiveDogPageState = ActiveDogPage.Arthur;
        DogsPageInstance.BeatriceButtonClick += _ => CurrentActiveDogPageState = ActiveDogPage.Beatrice;
        DogsPageInstance.DanteButtonClick    += _ => CurrentActiveDogPageState = ActiveDogPage.Dante;
        DogsPageInstance.DimitriButtonClick  += _ => CurrentActiveDogPageState = ActiveDogPage.Dimitri;
        DogsPageInstance.GatsbyButtonClick   += _ => CurrentActiveDogPageState = ActiveDogPage.Gatsby;
        DogsPageInstance.PaulineButtonClick  += _ => CurrentActiveDogPageState = ActiveDogPage.Pauline;
        DogsPageInstance.PercivalButtonClick += _ => CurrentActiveDogPageState = ActiveDogPage.Percival;
        DogsPageInstance.SylviaButtonClick   += _ => CurrentActiveDogPageState = ActiveDogPage.Sylvia;
        
        BookBackButtonInstanceClick += _ => CurrentActiveDogPageState = ActiveDogPage.None;
    }
}