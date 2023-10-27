namespace GreenCity;

public class Map
{
    private readonly Point _mapTileSize = new Point(4,3);
    private readonly Sprite[,] _tiles;
    public Point TileSize {get; private set;}
    public Point MapSize {get; private set;}

    public Map()
    {
        _tiles = new Sprite[_mapTileSize.X, _mapTileSize.Y];

        var textures = new List<Texture2D>();

        for (int i = 1; i < 6; i++){
            textures.Add(Globals.Content.Load<Texture2D>($"ground{i}"));
        }

        TileSize = new(textures[0].Width, textures[0].Height);
        MapSize = new(TileSize.X * _mapTileSize.X, TileSize.Y * _mapTileSize.Y);

        var random = new Random();

        for(int y = 0; y < _mapTileSize.Y; y++)
        {
            for(int x = 0; x < _mapTileSize.X; x++)
            {
                var r = random.Next(0, textures.Count());
                _tiles[x,y] = new(textures[r], new(x * TileSize.X, y * TileSize.Y));
            }
        }
    }

    public void Draw()
    {
        for(int y = 0; y < _mapTileSize.Y; y++)
        {
            for(int x = 0; x < _mapTileSize.X; x++)
            {
                _tiles[x,y].Draw();
            }
        }
    }
}