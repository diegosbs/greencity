namespace GreenCity;

public class Hero
{
    private Vector2 _position = new(100,100);
    private readonly float _speed = 200f;
    private readonly AnimationManager _anims = new();

    public Hero()
    {
        var heroTexture = Globals.Content.Load<Texture2D>("walkingtest");

        _anims.AddAnimation(new Vector2(0, -1), new(heroTexture, 8, 4, 0.1f, 1));
        _anims.AddAnimation(new Vector2(-1, 0), new(heroTexture, 8, 4, 0.1f, 2));
        _anims.AddAnimation(new Vector2(0, 1), new(heroTexture, 8, 4, 0.1f, 3));
        _anims.AddAnimation(new Vector2(1, 0), new(heroTexture, 8, 4, 0.1f, 4));
        _anims.AddAnimation(new Vector2(1, -1), new(heroTexture, 8, 4, 0.1f, 4));
        _anims.AddAnimation(new Vector2(1, 1), new(heroTexture, 8, 4, 0.1f, 4));
        _anims.AddAnimation(new Vector2(-1, -1), new(heroTexture, 8, 4, 0.1f, 2));
        _anims.AddAnimation(new Vector2(-1, 1), new(heroTexture, 8, 4, 0.1f, 2));
    }

    public void Update()
    {
        if(InputManager.Moving)
        {
            _position += Vector2.Normalize(InputManager.Direction) * _speed * Globals.TotalSeconds;
        }

        _anims.Update(InputManager.Direction);
    }

    public void Draw()
    {
        _anims.Draw(_position);
    }
}