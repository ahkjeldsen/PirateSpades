﻿// <copyright file="StartUp.cs">
//      mche@itu.dk, hclk@itu.dk
// </copyright>
// <summary>
//      Class used for making the start up screen
// </summary>
// <author>Morten Chabert Eskesen (mche@itu.dk)</author>
// <author>Helena Charlotte Lyn Krüger (hclk@itu.dk)</author>

namespace PirateSpadesGame.GameModes {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Media;
    using PirateSpadesGame.Misc;
    using PirateSpadesGame.Music;

    /// <summary>
    /// Class used for making the start up screen
    /// </summary>
    public class StartUp : IGameMode {
        private List<Button> buttons;
        private const int numberOfButtons = 5;
        private bool settingsEnabled;
        private bool rulesEnabled = false;
        private Sprite rules;
        private Button back;
        private Sprite settings;
        private PsGame game;
        private Button cancel;
        private Button apply;
        private Textbox playername;
        private string playerName = "Player Name:";
        private Vector2 playerNamePos;
        private SpriteFont font;
        private Numberbox volume;
        private Vector2 volumePos;
        private string volumeString = "Volume (in %):";
        private string scoreboardKey = "Press and hold TAB to show scoreboard \n when ingame";
        private Vector2 scoreboardPos;
        private string menuKey = "Press ESC to show menu when ingame";
        private Vector2 menuPos;
        private List<Button> settingsButton;
        private SongPlayer songPlayer;

        /// <summary>
        /// The constructor for StartUp takes a PsGame
        /// </summary>
        /// <param name="game">The currently running PsGame</param>
        public StartUp(PsGame game) {
            Contract.Requires(game != null);
            this.game = game;
            this.SetUp();
        }

        /// <summary>
        /// Set up the start screen
        /// </summary>
        private void SetUp() {
            this.SetUpRules();
            this.SetUpSettings();

            var x = game.Window.ClientBounds.Width / 2 - Button.Width / 2;
            var y = game.Window.ClientBounds.Height / 2 - numberOfButtons / 2 * Button.Height - (numberOfButtons % 2) * Button.Height / 2;

            buttons = new List<Button>();
            buttons.Add(new Button("joingame", x, y));
            y += Button.Height;
            buttons.Add(new Button("creategame", x, y));
            y += Button.Height;
            buttons.Add(new Button("rules", x, y));
            y += Button.Height;
            buttons.Add(new Button("settings", x, y));
            y += Button.Height;
            buttons.Add(new Button("exit", x, y));
        }

        /// <summary>
        /// Set up the rules menu
        /// </summary>
        public void SetUpRules() {
            rules = new Sprite { Color = Color.White };
            int rulesX = game.Window.ClientBounds.Width / 2 - 450 / 2;
            int rulesY = game.Window.ClientBounds.Height / 2 - 588 / 2;
            rules.Position = new Vector2(rulesX, rulesY);
            int backX = (rulesX + 450) / 2 + Button.Width / 2;
            int backY = (rulesY + 515);
            back = new Button("back", backX, backY);
        }

        /// <summary>
        /// Set up the settings menu
        /// </summary>
        private void SetUpSettings() {
            settingsButton = new List<Button>();
            settings = new Sprite { Color = Color.White };
            int settingsX = game.Window.ClientBounds.Width / 2 - 600 / 2;
            int settingsY = game.Window.ClientBounds.Height / 2 - 468 / 2;
            settings.Position = new Vector2(settingsX, settingsY);
            int cancelX = settingsX + 425;
            int cancelY = settingsY + 400;
            cancel = new Button("cancel", cancelX, cancelY);
            settingsButton.Add(cancel);
            int applyX = settingsX + 40;
            int applyY = settingsY + 400;
            apply = new Button("apply", applyX, applyY);
            settingsButton.Add(apply);
            var rect = new Rectangle(settingsX + (600-325), settingsY + 100, 250, 75);
            playername = new Textbox(rect, "playername") { Text = this.game.PlayerName };
            playername.MoveText(45);
            playerNamePos = new Vector2(settingsX+100, settingsY + 125);
            var volumeRect = new Rectangle(settingsX + (600 - 325) + 100, settingsY + 185, 100, 50);
            var a = (int)(game.MusicVolume * 100);
            volume = new Numberbox(volumeRect, "volumebox", 3) { Number = a, Limit = 100 };
            volume.Text = volume.Number.ToString();
            volumePos = new Vector2(settingsX + 100, settingsY + 200);
            scoreboardPos = new Vector2(settingsX + 100, settingsY + 250);
            menuPos = new Vector2(settingsX + 100, settingsY + 325);
        }

        /// <summary>
        /// Load the content of this StartUp
        /// </summary>
        /// <param name="contentManager">The ContentManager used to load the content</param>
        public void LoadContent(ContentManager contentManager) {
            rules.LoadContent(contentManager, "Gamerules");
            settings.LoadContent(contentManager, "Gamesettings");
            back.LoadContent(contentManager);
            font = contentManager.Load<SpriteFont>("font");
            cancel.LoadContent(contentManager);
            apply.LoadContent(contentManager);
            playername.LoadContent(contentManager);
            volume.LoadContent(contentManager);
            foreach(var b in buttons) {
                b.LoadContent(contentManager);
            }

            if(songPlayer == null) {
                MediaPlayer.Volume = game.MusicVolume;
                songPlayer = SongPlayer.GetInstance(contentManager);
                songPlayer.Start();
                songPlayer.PlayList.ShuffleList = true;
            } else if(!songPlayer.IsPlaying) {
                songPlayer.Start();
            }
        }

        /// <summary>
        /// Update this start screen
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Update(GameTime gameTime) {
            if(settingsEnabled) {
                foreach (var b in this.settingsButton.Where(b => b.Update(gameTime))) {
                    this.ButtonAction(b);
                }
                playername.Update(gameTime);
                volume.Update(gameTime);
            } else if(rulesEnabled) {
                if(back.Update(gameTime)) {
                    this.ButtonAction(back);
                }
            } else {
                foreach (var b in this.buttons.Where(b => b.Update(gameTime))) {
                    this.ButtonAction(b);
                }
            }
        }

        /// <summary>
        /// Helper method for taking action upon a button press
        /// </summary>
        /// <param name="b">The button to take action upon</param>
        private void ButtonAction(Button b) {
            Contract.Requires(b != null);
            var str = b.Name;
            switch(str) {
                case "joingame":
                    game.State = GameState.JoinGame;
                    break;
                case "creategame":
                    game.State = GameState.CreateGame;
                    break;
                case "rules":
                    rulesEnabled = true;
                    break;
                case "settings":
                    playername.Text = this.game.PlayerName;
                    settingsEnabled = true;
                    break;
                case "back":
                    rulesEnabled = false;
                    break;
                case "cancel":
                    CancelChanges();
                    settingsEnabled = false;
                    break;
                case "apply":
                    if(this.ApplyChanges()) {
                        settingsEnabled = false;
                    }
                    break;
                case "exit":
                    game.State = GameState.Exit;
                    break;
            }
        }

        /// <summary>
        /// Cancel the changes made in the settings menu
        /// </summary>
        private void CancelChanges() {
            Contract.Ensures(playername.Text == game.PlayerName);
            playername.Text = game.PlayerName;
            var a = (int)Math.Round(game.MusicVolume);
            volume.Number = a * 100;
            volume.Text = volume.Number.ToString();
        }

        /// <summary>
        /// Apply the changes made in the settings menu
        /// </summary>
        /// <returns>True if the settings are in the correct format</returns>
        private bool ApplyChanges() {
            Contract.Ensures(Regex.IsMatch(playername.Text, @"^[a-zA-Z0-9]{3,12}$") ? (game.PlayerName == playername.Text && game.MusicVolume == volume.ParseInputToFloat()) : false);
            if(Regex.IsMatch(playername.Text, @"^[a-zA-Z0-9]{3,12}$")) {
                game.PlayerName = playername.Text;
                game.MusicVolume = volume.ParseInputToFloat();
                MediaPlayer.Volume = game.MusicVolume;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Draw this start screen on the given SpriteBatch
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch</param>
        public void Draw(SpriteBatch spriteBatch) {
            foreach(var b in buttons) {
                b.Draw(spriteBatch);
            }
            if(rulesEnabled) {
                rules.Draw(spriteBatch);
                back.Draw(spriteBatch);
            }
            if(settingsEnabled) {
                settings.Draw(spriteBatch);
                apply.Draw(spriteBatch);
                cancel.Draw(spriteBatch);
                playername.Draw(spriteBatch);
                volume.Draw(spriteBatch);
                spriteBatch.DrawString(font, playerName, playerNamePos, Color.Black);
                spriteBatch.DrawString(font, volumeString, volumePos, Color.Black);
                spriteBatch.DrawString(font, scoreboardKey, scoreboardPos, Color.Black);
                spriteBatch.DrawString(font, menuKey, menuPos, Color.Black);
            }
        }
    }
}
