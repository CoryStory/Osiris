using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public static string PlayerName { get; set;}
    public static int PlayerLevel { get; set; }
}
