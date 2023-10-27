namespace GreenCity;

public class Hero : Sprite
{
    private Vector2 _position = new(100,100);
    private Vector2 _minPos, _maxPos;
    private readonly float _speed = 200f;
    private readonly AnimationManager _anims = new();

    public Hero(Texture2D texture, Vector2 position) : base(texture, position)
    {
        var heroTexture = Globals.Content.Load<Texture2D>("walkingtest");

        _anims.AddAnimation(new Vector2(0, -1), new(heroTexture, 9, 4, 0.1f, 1));
        _anims.AddAnimation(new Vector2(-1, 0), new(heroTexture, 9, 4, 0.1f, 2));
        _anims.AddAnimation(new Vector2(0, 1), new(heroTexture, 9, 4, 0.1f, 3));
        _anims.AddAnimation(new Vector2(1, 0), new(heroTexture, 9, 4, 0.1f, 4));
        _anims.AddAnimation(new Vector2(1, -1), new(heroTexture, 9, 4, 0.1f, 4));
        _anims.AddAnimation(new Vector2(1, 1), new(heroTexture, 9, 4, 0.1f, 4));
        _anims.AddAnimation(new Vector2(-1, -1), new(heroTexture, 9, 4, 0.1f, 2));
        _anims.AddAnimation(new Vector2(-1, 1), new(heroTexture, 9, 4, 0.1f, 2));
    }

    public void SetBounds(Point mapSize, Point tileSize)
    {
        _minPos = new Vector2(tileSize.X / 2, tileSize.Y / 2);
        _maxPos = new Vector2(mapSize.X - tileSize.X / 2, mapSize.Y - tileSize.Y / 2);
    }

    public void Update()
    {

        position += InputManager.Direction*Globals.TotalSeconds*speed;
        position = Vector2.Clamp(position, _minPos, _maxPos);
        if(InputManager.Moving)
        {
            _position += Vector2.Normalize(InputManager.Direction) * _speed * Globals.TotalSeconds;
        }

        if(_position.X > _minPos.X && _position.Y > _minPos.Y
         && _position.X < _maxPos.X && _position.Y < _maxPos.Y)

        _anims.Update(InputManager.Direction);
    }

    public override void Draw()
    {
                if(_position.X > _minPos.X && _position.Y > _minPos.Y
         && _position.X < _maxPos.X && _position.Y < _maxPos.Y)
        _anims.Draw(_position);
    }
}