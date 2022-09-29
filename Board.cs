class Yeet{

    List<string> space = new List<string>();

    public Bruh() {
        for (int i =1; i <=9; i++){
            space.Add(i.ToString());
        }
    }

    public bool ContainsUnclaimedSpaces(){
        static bool IsTie(Board space)
        {
            // If there is a digit, there are still moves to be made.
            bool foundDigit = false;

            foreach (string value in space)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }

            return !foundDigit;
        }
    }

    public bool IsPlayerWinner(string player) {
        if (space[0] == player && space[1] == player && space[2] == player){
            return true;
        }
        else if (space[3] == player && space[4] == player && space[5] == player){
            return true;
        }
        else if (space[6] == player && space[7] == player && space[8] == player){
            return true;
        }
        else if (space[2] == player && space[4] == player && space[6] == player){
            return true; 
        }
        else if (space[0] == player && space[4] == player && space[8] == player){
            return true;
        }
        else if (space[0] == player && space[3] == player && space[6] == player){
            return true;
        }
        else if (space[1] == player && space[4] == player && space[7] == player){
            return true;
        }
        else if (space[2] == player && space[5] == player && space[8] == player){
            return true;
        }


        return false;
    }
}