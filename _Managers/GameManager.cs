namespace GreenCity;

public class GameManager
{
    //private readonly Ship _ship;
    private readonly Hero _hero;

    public GameManager()
    {
        _hero = new();
    }

    public void Update()
    {
        InputManager.Update();
        _hero.Update();
    }

    public void Draw()
    {
        _hero.Draw();
    }
}
