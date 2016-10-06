using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

	public static void LoadAllInformation()
    {
        PlayerInfo.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        PlayerInfo.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        PlayerInfo.PlayerStrength = PlayerPrefs.GetInt("PLAYERSTRENGTH");
        PlayerInfo.PlayerSpeed = PlayerPrefs.GetInt("PLAYERSPEED");
        PlayerInfo.PlayerWillpower = PlayerPrefs.GetInt("PLAYERWILLPOWER");
        PlayerInfo.PlayerIntellect = PlayerPrefs.GetInt("PLAYERINTELLECT");
        PlayerInfo.PlayerProgress = PlayerPrefs.GetFloat("PLAYERPROGRESS");
    }
}
