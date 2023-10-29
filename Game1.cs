using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Lab5
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public const int WINDOWWIDTH = 800;
        public const int WINDOWHEIGHT = 600;
        Texture2D playerTextureRed;
        Texture2D playerTextureBlue;
        Texture2D playerTextureGreen;
        Rectangle playerRectangleRed;
        Rectangle playerRectangleGreen;
        Rectangle playerRectangleBlue;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _graphics.PreferredBackBufferHeight = WINDOWHEIGHT;
            _graphics.PreferredBackBufferWidth = WINDOWWIDTH;
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            playerTextureRed = Content.Load<Texture2D>("Sprites/sarabot");
            playerRectangleRed = new Rectangle(100, 100, playerTextureRed.Width, playerTextureRed.Height);
            playerTextureBlue = Content.Load<Texture2D>("Sprites/sarabot");
            playerRectangleBlue = new Rectangle(100, 200, playerTextureBlue.Width, playerTextureBlue.Height);
            playerTextureGreen = Content.Load<Texture2D>("Sprites/sarabot");
            playerRectangleGreen = new Rectangle(100, 300, playerTextureGreen.Width, playerTextureGreen.Height);
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(playerTextureRed, playerRectangleRed, Color.Red);
            _spriteBatch.Draw(playerTextureBlue, playerRectangleBlue, Color.Blue);
            _spriteBatch.Draw(playerTextureGreen, playerRectangleGreen, Color.Green);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}