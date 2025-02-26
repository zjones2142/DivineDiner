using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class Talkable : MonoBehaviour
{
    public string[] dialogueLines;
    public TextMeshProUGUI dialogue;
    public int dialogueCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueCounter = 0;
        dialogue.SetText(dialogueLines[dialogueCounter]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(dialogueCounter == 20){
                dialogueCounter = 0;
            }
            dialogue.SetText(dialogueLines[dialogueCounter]);
            dialogueCounter++;
        }
    }

    // void ChangeText()
    // {
    //     if(Input.GetMouseButtonDown(0)){
    //         dialogue.SetText(dialogueLines[dialogueCounter]);
    //         dialogueCounter++;
    //         Debug.Log(dialogueCounter);
    //     }
    // }
}
