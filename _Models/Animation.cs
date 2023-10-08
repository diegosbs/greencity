namespace GreenCity
{
    public class Animation
    {
        private readonly Texture2D _texture;
        private readonly List<Rectangle> _sourceRectangle = new List<Rectangle>();
        private readonly int _frames;
        private int _frame;
        private readonly float _frameTime;
        private float _frameTimeLeft;
        private bool _active = true;

        public Animation (Texture2D texture, int framesX, int framesY, float frameTime, int row = 1){
            _texture = texture;
            _frameTime = frameTime;
            _frameTimeLeft = _frameTime;
            _frames = framesX;
            var frameWidth = _texture.Width/framesX;
            var frameHeight = _texture.Height/framesY;

            for(int i = 0; i < _frames; i++){
                _sourceRectangle.Add(new(i*frameWidth, (row - 1) * frameHeight , frameWidth, frameHeight));
            }
        }

        public void Stop()
        {
            _active = false;
        }

        public void Start()
        {
            _active = true;
        }

        public void Reset()
        {
            _frame = 0;
            _frameTimeLeft = _frameTime;    
        }

        public void Update()
        {
            if(!_active) return;

            _frameTimeLeft -= Globals.TotalSeconds;
            if(_frameTimeLeft <= 0)
            {
                _frameTimeLeft += _frameTime;
                _frame = (_frame + 1) % _frames;
            }    
        }

        public void Draw(Vector2 pos)
        {
            Globals.SpriteBatch.Draw(_texture, pos, _sourceRectangle[_frame], Color.White, 0,Vector2.Zero, Vector2.One, SpriteEffects.None, 1);
        }
    }
}