namespace GreenCity;

public class Ship : Sprite
{
    private float _rotation;
    private readonly float _rotationSpeed;

    public Ship(Texture2D tex, Vector2 pos) : base(tex, pos)
    {
        _rotation = 0;
        _rotationSpeed = 3f;
    }

    public void Update()
    {
        // Obtém a entrada das teclas de seta
        float horizontalInput = InputManager.DirectionArrows.X;
        float verticalInput = InputManager.DirectionArrows.Y;

        // Obtém a posição atual do mouse
        MouseState mouseState = Mouse.GetState();
        Vector2 mousePosition = new Vector2(mouseState.X, mouseState.Y);

        // Calcula a posição do mouse em relação à posição do jogador
        Vector2 direction = mousePosition - position;

        // Define a rotação para 0 graus quando o mouse está à esquerda do jogador (direção.X < 0)
        // e para 180 graus quando o mouse está à direita do jogador (direção.X >= 0)
        if (direction.X >= 0)
        {
            _rotation = MathHelper.ToRadians(90);
        }
        else
        {
            _rotation = MathHelper.ToRadians(270); 
        }

        // Atualiza a posição com base nas teclas de seta
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        position += movement * speed * Globals.TotalSeconds;
    }

    public override void Draw()
    {
        Globals.SpriteBatch.Draw(texture, position, null, Color.White, _rotation, origin, 1, SpriteEffects.None, 1);
    }
}
