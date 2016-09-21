using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogBox : MonoBehaviour {
    private Text dialogText;
    private Image dialogBox;
    private TextAsset text;
    private string[] lines;
    private Image characterTalking;
    private bool dialogLocked;
    private int currentLine;
    private int endAtLine;
    private bool loadSceneOnEnd;
    private string nextScene;
    // Use this for initialization
    void Start () {
        dialogBox = GameObject.Find("DialogBox").GetComponent<Image>();
        characterTalking = GameObject.Find("CharacterTalking").GetComponent<Image>();
        dialogText = GameObject.Find("DialogText").GetComponent<Text>();
        dialogLocked = false;
        loadSceneOnEnd = false;
        
      
        
    }
	
	// Update is called once per frame
	void Update () {
        
        dialogIncrement();

        if (text != null)
        {
            if (currentLine > endAtLine)
            {
                Debug.Log("CurrentLine: " + currentLine);
                Debug.Log("EndAtLine: " + endAtLine);
                
                if (loadSceneOnEnd && nextScene != null)
                {
                    
                    SceneManager.LoadScene(nextScene);
                }
                else
                {

                }
            }
            else
            {
                dialogText.text = lines[currentLine];
            }
        }
        
	}
    public void changeText(TextAsset text)
    {
        if (text != null)
        {
            this.text = text;
            lines = (text.text.Split('\n'));
            currentLine = 0;
            endAtLine = lines.Length-1;
        }
    }
    private void dialogIncrement()
    {
        if(Input.GetKeyDown(KeyCode.Return) && !dialogLocked){
            currentLine++;
        }
    }
    public void setLoadSceneOnEnd(bool b)
    {
        loadSceneOnEnd = b;
    }
    public void setNextScene(string s)
    {

        nextScene = s;
    }
}
