namespace GreenCity;

public class GameManager
{
    //private readonly Ship _ship;
    private readonly Hero _hero;
    private readonly Map _map;

    public GameManager()
    {
        _map = new();
        _hero = new(Globals.Content.Load<Texture2D>("walkingtest"), new(Globals.WindowSize.X/2, Globals.WindowSize.Y/2));
        _hero.SetBounds(_map.MapSize, _map.TileSize);
    }

    public void Update()
    {
        InputManager.Update();
        _hero.Update();
    }

    public void Draw()
    {
        _map.Draw();
        _hero.Draw();
    }
}
