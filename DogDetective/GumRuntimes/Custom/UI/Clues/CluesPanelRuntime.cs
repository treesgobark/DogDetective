namespace DogDetective.GumRuntimes.Custom.UI.Clues;

public partial class CluesPanelRuntime
{
    partial void CustomInitialize()
    {
    }

    public void InitializeButtons(GameScreenGumRuntime gumScreen)
    {
        MainUiPanelInstance.InitializeMenuButtons(gumScreen);
        MainUiPanelInstance.CluesBackButton.Click += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.None;
    }
}