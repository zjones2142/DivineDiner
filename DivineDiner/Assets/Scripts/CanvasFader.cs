using System.Collections;
using UnityEngine;

public class CanvasFader : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        StartCoroutine(FadeCanvas(0f, 1f, 1.5f));
    }

    public void FadeIn(float duration)
    {
        StartCoroutine(FadeCanvas(0f, 1f, duration)); // Fade in
    }

    public void FadeOut(float duration)
    {
        StartCoroutine(FadeCanvas(1f, 0f, duration)); // Fade out
    }

    private IEnumerator FadeCanvas(float startAlpha, float endAlpha, float duration)
    {
        float time = 0f;

        while (time < duration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, time / duration);
            yield return null;
        }

        canvasGroup.alpha = endAlpha;
    }
}
