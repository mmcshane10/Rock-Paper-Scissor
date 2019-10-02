namespace RPS.Models
{
    public class Game
    {
        private Item _player1Item;
        private Item _player2Item;

        public Game(string player1, string player2)
        {
            _player1Item =  new Item(player1);
            _player2Item = new Item(player2);
        }

        public string DetermineWinner()
        {
            string resultString = "";

            int result = _player1Item.Number + _player2Item.Number;

            if (result == 2 || result == 4 || result == 8)
            {
                resultString = "Game ends in a tie";
            }
            else if (result == 3)
            {
                resultString = "paper wins";
            } else if ( result == 5)
            {
                resultString = "rock wins";
            } else if (result == 6)
            {
                resultString = "scissors wins";
            }
            return resultString;
        }


    }

}