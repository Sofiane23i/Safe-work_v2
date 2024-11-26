using UnityEngine;

public class CanvasFadeIn : MonoBehaviour
{
    public CanvasGroup canvasGroup;  // Reference to the CanvasGroup
    public float fadeDuration = 2f;  // Duration of the fade-in effect

    private void Start()
    {
        // Ensure the canvas starts fully transparent
        canvasGroup.alpha = 0f;

        // Start the fade-in process
        StartCoroutine(FadeIn());
    }

    private System.Collections.IEnumerator FadeIn()
    {
        float elapsedTime = 0f;

        // Gradually increase the alpha over time
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            yield return null;
        }

        // Ensure the canvas is fully opaque after the fade-in
        canvasGroup.alpha = 1f;
    }
}
