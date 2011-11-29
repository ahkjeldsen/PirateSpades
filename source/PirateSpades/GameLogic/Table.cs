﻿using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace PirateSpades.GameLogic {
    public class Table {
        private Card open;
        private static readonly Table Me = new Table();
        private List<Player> players;
        private Player winning;
        private List<Card> cards;
        private Card winningCard;
        private Dictionary<Player, Card> playedCards;
        private int CurrentPlayerIndex = 0;

        private Table() {
            open = null;
            winning = null;
            cards = new List<Card>();
        }

        public static Table GetTable() {
            return Me;
        }

        public int Players { get { return players.Count; } }

        public int Cards { get { return cards.Count; } }

        public Card OpeningCard { get { return open; } }

        public Player Winning { get { return winning; } }

        public int CardsPlayed { get; set; }

        public Player PlayerTurn { get; set; }

        public Player StartingPlayer { get; set; }

        public bool SameSuit(Player p) {
            Contract.Requires(p.CardToPlay != null && OpeningCard != null);
            Contract.Ensures(p.CardToPlay.Suit == OpeningCard.Suit ? Contract.Result<bool>() : true ||
                !p.AnyCard(OpeningCard.Suit) ? Contract.Result<bool>() : true);
            return p.Playable(p.CardToPlay);
        }

        public void AddPlayers(List<Player> p) {
            Contract.Requires(p != null);
            Contract.Ensures(Players == p.Count);
            players = new List<Player>(p);
        }

        public void ReceiveCard(Player p, Card c) {
            Contract.Requires(this.SameSuit(p) || StartingPlayer == PlayerTurn);
            Contract.Requires(p != null && !this.IsRoundFinished() && PlayerTurn == p);
            CurrentPlayerIndex += 1 % players.Count;
            if(open == null) {
                playedCards.Clear();
                cards.Add(c);
                CardsPlayed++;
                open = c;
                playedCards.Add(p, c);
                PlayerTurn = players[CurrentPlayerIndex];
                return;
            }
            cards.Add(c);
            CardsPlayed++;
            if(!this.IsRoundFinished()) {
                PlayerTurn = players[CurrentPlayerIndex];
                return;
            }
            this.FinishRound();
        }

        public bool IsRoundFinished() {
            Contract.Ensures(Cards == Players ? Contract.Result<bool>() : true);
            return Cards == Players;
        }

        public void FinishRound() {
            Contract.Requires(this.IsRoundFinished() && Winning != null);
            Contract.Ensures(OpeningCard == null && Cards == 0);
            foreach (var kvp in this.playedCards.Where(kvp => this.winning == null || this.winningCard.CompareTo(kvp.Value) < 0)) {
                this.winning = kvp.Key;
                this.winningCard = kvp.Value;
            }
            winning.ReceiveTrick(cards);
            cards.Clear();
            PlayerTurn = Winning;
            winning = null;
            winningCard = null;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant() {
            Contract.Invariant(Players <= 5);
            Contract.Invariant(Cards > 0 && Cards <= Players);
        }
    }
}
