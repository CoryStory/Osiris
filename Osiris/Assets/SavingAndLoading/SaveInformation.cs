using UnityEngine;
using System.Collections;

public class SaveInformation : MonoBehaviour {

	public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", PlayerInfo.PlayerLevel);
    }
}
