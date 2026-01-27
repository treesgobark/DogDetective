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
        
        MapBackButton.Click   += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.None;
        CluesBackButton.Click += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.None;
        DogsBackButton.Click  += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.None;
    }
}
