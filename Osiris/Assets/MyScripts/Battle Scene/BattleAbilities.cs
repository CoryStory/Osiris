using UnityEngine;
using System.Collections;

public class BattleAbilities : MonoBehaviour {

	float fade = 0;
	float fadeSpeed = 5;
	bool spaceDown = false;
	// Use this for initialization
	void Start () {
		//fade = this.GetComponent<CanvasGroup> ().alpha;

	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<CanvasGroup> ().alpha = fade;
		if (Input.GetKeyDown (KeyCode.Space)) {
			spaceDown = true;

		}
		if (spaceDown == true) {
			if (fade <= 0) {
				fade += Time.deltaTime;
			} else if (fade >= 1) {
				fade -= Time.deltaTime;
			}
		}
	}
}
