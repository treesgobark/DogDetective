namespace DogDetective.GumRuntimes.Custom.UI.Dogs;

public partial class DogsPanelRuntime
{
    partial void CustomInitialize()
    {
    }

    public void InitializeButtons(GameScreenGumRuntime gumScreen)
    {
        MainUiPanelInstance.InitializeMenuButtons(gumScreen);
        MainUiPanelInstance.DogsBackButton.Click += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.None;
    }
}