using Laboratorio_3_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio_3_OOP_201902
{
    public class Game
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private Player[] players;
        private Player activePlayer;
        private List<Deck> decks;
        private List<Card>[] captainCards;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            List<Deck> decks = new List<Deck>();
            List<Card>[] captainCards = new List<Card>[DEFAULT_NUMBER_OF_PLAYERS];
        }

        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public List<Deck> Decks
        {
            get
            {
                return this.decks;
            }
        }
        public List<Card>[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            if (players[0].LifePoints == 0 || players[1].LifePoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetWinner()
        {
            if (players[0].LifePoints == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void Play()
        {
            throw new NotImplementedException();
        }
        public void ReadDecks()
        {
            StreamReader reader = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Decks.txt");
            StreamWriter writer = new StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Decks.txt");


            reader.Close();
            writer.Close();
        }

        public void ReadCaptains()
        {
            StreamReader reader = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Captains.txt");
            StreamWriter writer = new StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Captains.txt");


            reader.Close();
            writer.Close();
        }

    }
}
