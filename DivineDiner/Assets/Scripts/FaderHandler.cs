using UnityEngine;

public class FaderHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // Press 'F' to fade in
        {
            GetComponent<CanvasFader>().FadeIn(1.5f);
        }

        if (Input.GetKeyDown(KeyCode.G)) // Press 'G' to fade out
        {
            GetComponent<CanvasFader>().FadeOut(1.5f);
        }
    }
}
