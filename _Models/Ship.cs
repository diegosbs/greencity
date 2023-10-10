// namespace GreenCity;

// public class Ship : Sprite
// {
//     private float _rotation;
//     private readonly float _rotationSpeed;

//     public Ship(Texture2D tex, Vector2 pos) : base(tex, pos)
//     {
//         _rotation = 0;
//         _rotationSpeed = 3f;
//     }

//     public void Update()
//     {
//         // Obtém a entrada das teclas de seta
//         float horizontalInput = InputManager.DirectionArrows.X;
//         float verticalInput = InputManager.DirectionArrows.Y;

//         // Atualiza a posição com base nas teclas de seta
//         Vector2 movement = new Vector2(horizontalInput, verticalInput);
//         position += movement * speed * Globals.TotalSeconds;

//         // Define a rotação baseada na direção das setas
//         if (horizontalInput > 0)
//         {
//             // Se a seta da direita está pressionada
//             _rotation = MathHelper.ToRadians(90);
//         }
//         else if (horizontalInput < 0)
//         {
//             // Se a seta da esquerda está pressionada
//             _rotation = MathHelper.ToRadians(270);
//         }
//         else if (verticalInput > 0)
//         {
//             // Se a seta para cima está pressionada
//             _rotation = MathHelper.ToRadians(180);
//         }
//         else if (verticalInput < 0)
//         {
//             // Se a seta para baixo está pressionada
//             _rotation = MathHelper.ToRadians(0);
//         }
//     }

//     public override void Draw()
//     {
//         Globals.SpriteBatch.Draw(texture, position, null, Color.White, _rotation, origin, 1, SpriteEffects.None, 1);
//     }
// }
