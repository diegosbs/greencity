namespace GreenCity;

public class GameManager
{
    private readonly Ship _ship;

    public GameManager()
    {
        _ship = new(Globals.Content.Load<Texture2D>("ship"), new(200, 200));
    }

    public void Update()
    {
        InputManager.Update();
        _ship.Update();
    }

    public void Draw()
    {
        _ship.Draw();
    }
}
