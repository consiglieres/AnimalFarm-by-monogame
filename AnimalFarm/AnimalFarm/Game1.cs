using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace AnimalFarm
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D _backGround;
        Texture2D _chicken;
        Texture2D _cow;
        Texture2D _goat;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 1000;
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _backGround = Content.Load<Texture2D>("grass");
            _chicken = Content.Load<Texture2D>("chicken");
            _goat = Content.Load<Texture2D>("goat");
            _cow = Content.Load<Texture2D>("cow");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
                    
                

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_backGround, Vector2.Zero, Color.White);
            _spriteBatch.Draw(_chicken, new Vector2(RandomUnit.RandomChicken(), RandomUnit.RandomChicken()), Color.GhostWhite);
            _spriteBatch.Draw(_goat, new Vector2(RandomUnit.Goat(), RandomUnit.Goat()), Color.GhostWhite);
            _spriteBatch.Draw(_cow, new Vector2(RandomUnit.Cow(), RandomUnit.Cow()), Color.GhostWhite);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        
    }
}