using TMPro;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public GameObject startChar;
    public GameObject endChar;
    public TextMeshProUGUI charNameBox;
    public int counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter = 0;
        startChar.SetActive(true);
        endChar.SetActive(false);
        charNameBox.SetText("Aelius");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(counter == 20){
                counter = 0;
            }
            counter++;
            if(counter % 2 == 0){
                endChar.SetActive(true);
                startChar.SetActive(false);
                charNameBox.SetText("Zeus");
            }
            else{
                endChar.SetActive(false);
                startChar.SetActive(true);
                charNameBox.SetText("Aelius");
            }
        }
    }
}
