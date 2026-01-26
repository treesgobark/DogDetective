using FlatRedBall.Audio;
using Gum.Wireframe;

namespace DogDetective.GumRuntimes.Custom.UI.Map;

public partial class MapPanelRuntime
{
    partial void CustomInitialize()
    {
    }
    
    public void InitializeButtons(GameScreenGumRuntime gumScreen)
    {
        CreateRoomButtonHandler(ArthursRoomButton,   GameScreenGumRuntime.CurrentRoom.ArthursRoom,   gumScreen);
        CreateRoomButtonHandler(DiningRoomButton,    GameScreenGumRuntime.CurrentRoom.DiningRoom,    gumScreen);
        CreateRoomButtonHandler(FoyerButton,         GameScreenGumRuntime.CurrentRoom.Foyer,         gumScreen);
        CreateRoomButtonHandler(GardenButton,        GameScreenGumRuntime.CurrentRoom.Garden,        gumScreen);
        CreateRoomButtonHandler(KitchenButton,       GameScreenGumRuntime.CurrentRoom.Kitchen,       gumScreen);
        CreateRoomButtonHandler(LivingRoomButton,    GameScreenGumRuntime.CurrentRoom.LivingRoom,    gumScreen);
        CreateRoomButtonHandler(MainEntranceButton,  GameScreenGumRuntime.CurrentRoom.MainEntrance,  gumScreen);
        CreateRoomButtonHandler(PercivalsRoomButton, GameScreenGumRuntime.CurrentRoom.PercivalsRoom, gumScreen);
        CreateRoomButtonHandler(StudyButton,         GameScreenGumRuntime.CurrentRoom.Study,         gumScreen);
        CreateRoomButtonHandler(MasterBedroomButton, GameScreenGumRuntime.CurrentRoom.SylviasRoom,   gumScreen);

        MainUiPanelInstance.InitializeMenuButtons(gumScreen);
        MainUiPanelInstance.MapBackButton.Click += _ => gumScreen.CurrentActiveMenuState = GameScreenGumRuntime.ActiveMenu.None;
    }

    private void CreateRoomButtonHandler(
        GraphicalUiElement mapButton,
        GameScreenGumRuntime.CurrentRoom newRoom,
        GameScreenGumRuntime gumScreen
    )
    {
        mapButton.Click += _ =>
        {
            gumScreen.CurrentCurrentRoomState = newRoom;
            gumScreen.CurrentActiveMenuState  = GameScreenGumRuntime.ActiveMenu.None;
            AudioManager.Play(GlobalContent.DoorClose);
            AudioManager.Play(GlobalContent.CloseBook);
        };
    }
}