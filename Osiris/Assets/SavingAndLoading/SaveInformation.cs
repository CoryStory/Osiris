using UnityEngine;
using System.Collections;

namespace Osiris
{
    public class SaveInformation : MonoBehaviour
    {

        public static void SaveAllInformation()
        {
            PlayerPrefs.SetInt("PLAYERLEVEL", PlayerInfo.PlayerLevel);
            PlayerPrefs.SetString("PLAYERNAME", PlayerInfo.PlayerName);
            PlayerPrefs.SetInt("PLAYERSPEED", PlayerInfo.PlayerSpeed);
            PlayerPrefs.SetInt("PLAYERSTRENGTH", PlayerInfo.PlayerStrength);
            PlayerPrefs.SetInt("PLAYERINTELLECT", PlayerInfo.PlayerIntellect);
            PlayerPrefs.SetInt("PLAYERWILLPOWER", PlayerInfo.PlayerWillpower);
        }
    }
}