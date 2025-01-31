// <copyright file="PSGame.cs">
//      mche@itu.dk
// </copyright>
// <summary>
//      This is the main type for our game
// </summary>
// <author>Morten Chabert Eskesen (mche@itu.dk)</author>
// <author>Helena Charlotte Lyn Kr�ger (hclk@itu.dk)</author>

namespace PirateSpadesGame {
    using System.Diagnostics.Contracts;
    using System.Text.RegularExpressions;
    using PirateSpades.GameLogic;
    using PirateSpades.Network;
    using PirateSpadesGame.GameModes;
    using PirateSpadesGame.Misc;
    using PirateSpadesGame.Settings;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Game = PirateSpades.GameLogic.Game;

    /// <summary>
    /// This is the main type for our game
    /// </summary>
    public class PsGame : Microsoft.Xna.Framework.Game {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private IGameMode gameMode;
        private StartUp startUp;
        private JoinGame joinGame;
        private CreateGame createGame;
        private InGame inGame;
        private Sprite title;
        private Sprite background;
        private Sprite namePopUp;
        private Button ok;
        private Textbox textbox;
        private bool settingname = false;

        public PsGame() {
            graphics = new GraphicsDeviceManager(this) { PreferredBackBufferWidth = 1024, PreferredBackBufferHeight = 720 };
            Content.RootDirectory = "Content";
            State = GameState.StartUp;
            MusicVolume = PirateSettings.GetFloat("musicvolume");
            PlayerName = PirateSettings.GetString("playername");
        }

        /// <summary>
        /// The width of the screen
        /// </summary>
        public static int Width { get {
            Contract.Ensures(Width > 0); return 1024; } }

        /// <summary>
        /// The height of the screen
        /// </summary>
        public static int Height { get { Contract.Ensures(Height > 0); return 720; } }

        /// <summary>
        /// Is the screen active?
        /// </summary>
        public static bool Active { get; private set; }

        /// <summary>
        /// The host
        /// </summary>
        public PirateHost Host { get; set; }

        /// <summary>
        /// The client
        /// </summary>
        public PirateClient Client { get; set; }

        /// <summary>
        /// The game being played
        /// </summary>
        public Game PlayingGame { get; set; }

        /// <summary>
        /// The name of the game
        /// </summary>
        public string GameName { get; set; }

        /// <summary>
        /// Number of max players in the current game
        /// </summary>
        public int MaxPlayers { get; set; }

        /// <summary>
        /// The name of the player using this game
        /// </summary>
        public string PlayerName { get; set; }

        /// <summary>
        /// The state of the game
        /// </summary>
        public GameState State { get; set; }

        /// <summary>
        /// The volume level of the game
        /// </summary>
        public float MusicVolume { get; set; }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() {
            this.IsMouseVisible = true;

            title = new Sprite();
            background = new Sprite();
            var x = this.Window.ClientBounds.Width / 2 - 200;
            title.Position = new Vector2(x, 0);
            startUp = new StartUp(this);
            gameMode = startUp;

            base.Initialize();
        }

        /// <summary>
        /// Method for saving player states between games
        /// </summary>
        protected new void Exit() {
            PirateSettings.Set("playername", PlayerName);
            PirateSettings.Set("musicvolume", MusicVolume);
            PirateSettings.Save();
            base.Exit();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            background.LoadContent(this.Content, "PIRATESHIP");
            title.LoadContent(this.Content, "pspades");
            gameMode.LoadContent(this.Content);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent() {
            this.Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime) {
            // Allows the game to exit
            if(GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            Active = this.IsActive;

            if(settingname && (State == GameState.JoinGame || State == GameState.CreateGame)) {
                if(ok.Update(gameTime)) {
                    this.ButtonAction(ok);
                }
                textbox.Update(gameTime);
            } else {
                this.GameMode(gameTime);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// Switch between the different GameStates and update the current GameMode
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        private void GameMode(GameTime gameTime) {
            switch(State) {
                case GameState.StartUp:
                    if(!(gameMode is StartUp)) {
                        gameMode = startUp;
                    }
                    gameMode.Update(gameTime);
                    break;
                case GameState.InGame:
                    if(!(gameMode is InGame)) {
                        inGame = new InGame(this);
                        gameMode = inGame;
                        gameMode.LoadContent(this.Content);
                    }
                    gameMode.Update(gameTime);
                    break;
                case GameState.JoinGame:
                    if(PlayerName == "" || !Regex.IsMatch(PlayerName, @"^[a-zA-Z0-9]{3,12}$")) {
                        this.SetName();
                        break;
                    }
                    if(!(gameMode is JoinGame)) {
                        joinGame = new JoinGame(this);
                        gameMode = joinGame;
                        gameMode.LoadContent(this.Content);
                    }
                    gameMode.Update(gameTime);
                    break;
                case GameState.CreateGame:
                    if(PlayerName == "" || !Regex.IsMatch(PlayerName, @"^[a-zA-Z0-9]{3,12}$")) {
                        this.SetName();
                        break;
                    }
                    if(!(gameMode is CreateGame)) {
                        createGame = new CreateGame(this);
                        gameMode = createGame;
                        gameMode.LoadContent(this.Content);
                    }
                    gameMode.Update(gameTime);
                    break;
                case GameState.Exit:
                    this.Exit();
                    break;
            }
        }

        /// <summary>
        /// Helper method for taking action upon a button press
        /// </summary>
        /// <param name="b">The button that has been pressed</param>
        private void ButtonAction(Button b) {
            if(b == null) {
                return;
            }
            var str = b.Name;
            switch(str) {
                case "ok":
                    if(Regex.IsMatch(textbox.Text, @"^\w{3,20}$")) {
                        settingname = false;
                        this.PlayerName = textbox.Text;
                    } else {
                        settingname = true;
                    }
                    break;
            }
        }

        /// <summary>
        /// Helper method for setting a name if none has been specified yet
        /// </summary>
        private void SetName() {
            settingname = true;
            namePopUp = new Sprite();
            namePopUp.LoadContent(this.Content, "PopUp");
            int x = this.Window.ClientBounds.Width / 2 - namePopUp.Tex.Width / 2;
            int y = this.Window.ClientBounds.Height / 2 - namePopUp.Tex.Height / 2;
            namePopUp.Position = new Vector2(x, y);
            var rect = new Rectangle(x + (namePopUp.Tex.Width - 250), y + 50, 250, 75);
            textbox = new Textbox(rect, "playername") { Text = this.PlayerName, Typable = true };
            textbox.MoveText(45);
            textbox.LoadContent(this.Content);
            int okX = x + namePopUp.Tex.Width / 2 - 75;
            int okY = y + 150;
            ok = new Button("ok", okX, okY);
            ok.LoadContent(this.Content);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            background.Draw(spriteBatch);
            title.Draw(spriteBatch);
            gameMode.Draw(this.spriteBatch);
            if(settingname) {
                namePopUp.Draw(this.spriteBatch);
                textbox.Draw(this.spriteBatch);
                ok.Draw(this.spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }

    /// <summary>
    /// Class used for describing the state of the game
    /// </summary>
    public enum GameState {
        StartUp, InGame, JoinGame, CreateGame, Exit
    }
}
