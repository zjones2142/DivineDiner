using UnityEngine;

public class stateChange : MonoBehaviour
{
    public enum satisfactionLevel {
        Low,
        Medium,
        High
    };

    satisfactionLevel state = satisfactionLevel.Low;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(state == satisfactionLevel.Low){
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
