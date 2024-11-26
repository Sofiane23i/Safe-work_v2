using UnityEngine;

public class CanvasFadeOut : MonoBehaviour
{
    public CanvasGroup canvasGroup;  // Reference to the CanvasGroup component
    public float fadeDuration = 2f;  // Duration of the fade-out in seconds

    private float fadeTimer;

    void Start()
    {
        // Start fading immediately on start
        fadeTimer = fadeDuration;
    }

    void Update()
    {
        // Reduce the timer and update the alpha value
        if (fadeTimer > 0)
        {
            fadeTimer -= Time.deltaTime;
            canvasGroup.alpha = fadeTimer / fadeDuration;

            // Ensure the Canvas becomes completely invisible after fading
            if (canvasGroup.alpha <= 0)
            {
                canvasGroup.alpha = 0;
                enabled = false;  // Disable the script after fade out
                gameObject.SetActive(false);
            }
        }
    }
}
