using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectX.Graphics
{
    public class Sprite
    {
        public Texture2D texture { get; private set; }

        public int x { get; private set; }
        public int y { get; private set; }

        public int width{ get; set; }
        public int height { get; set; }
        public Color TintColor { get; set; } = Color.White;

        public Sprite(Texture2D _texture, int _x, int _y, int _width, int _height)
        {
            
        }

        public void Draw(SpriteBatch _spriteBatch, Vector2 vector)
        {
            _spriteBatch.Draw(texture, vector, new Rectangle(x, y, width, height), TintColor);
        }
    }
}
