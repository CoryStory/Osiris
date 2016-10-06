using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    private DialogBox db;
    // private BackPack
    private PlayerMovement pm;
	void Start () {
        db = GameObject.Find("DialogBox").GetComponent<DialogBox>();
        pm = this.gameObject.GetComponent<PlayerMovement>();
        closeDialogBox();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    private void lockMovement()
    {
        pm.lockMovement();
    }
    private void unlockMovement()
    {
        pm.unlockMovement();
    }
    private void openDialogBox(TextAsset text)
    {
        db.changeText(text);
        db.gameObject.SetActive(true);

    }
    private void closeDialogBox()
    {
        db.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
    }
    private void setScene(string s)
    {
        db.setNextScene(s);
    }
    private void setLoadSceneOnEnd(bool t)
    {
        db.setLoadSceneOnEnd(t);
    }
}
