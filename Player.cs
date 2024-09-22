string player1 = "Crosby";
string player2 = "Malkin";
string player3 = "Guentzel";

// Brute force comparison (equality only)
bool isSamePlayer = player1.Length == player3.Length;
if (isSamePlayer)
{
    for (int i = 0; i < player1.Length; i++)
    {
        if (player1[i] != player3[i])
        {
            isSamePlayer = false;
            break;
        }
    }
}

// Direct comparison
bool isEqual = player1 == player3; // False
bool isGreater = player1.CompareTo(player3) > 0; // False
bool isLessOrEqual = player2.CompareTo(player2) <= 0; // True

// Reference checking
bool isSameReference = ReferenceEquals(player1, player1); // True
bool isDifferentReference = ReferenceEquals(player2, player1); // False
