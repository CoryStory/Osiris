using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour {
    public TextAsset dialogBeforeFight;
    public string nextScene = "BATTLE1";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
        Debug.Log("collision");
		if(other.gameObject.tag == "Player"){
            Debug.Log("Collision with player");
            other.gameObject.SendMessage("openDialogBox", dialogBeforeFight);
            other.gameObject.SendMessage("setLoadSceneOnEnd", true);
            other.gameObject.SendMessage("lockMovement");
            other.gameObject.SendMessage("setScene", nextScene);
		}
	}
}
