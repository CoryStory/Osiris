using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public static string PlayerName { get; set;}
    public static int PlayerLevel { get; set; }
    public static int PlayerSpeed { get; set; }
    public static int PlayerWillpower { get; set; }
    public static float PlayerProgress { get; set; }
    public static int PlayerStrength { get; set; }
    public static int PlayerIntellect { get; set; }
}
