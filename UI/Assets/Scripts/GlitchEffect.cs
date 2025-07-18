using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlitchEffect : MonoBehaviour
{
    public float glitchDuration = 1f;
    public string nextSceneName;
    public Sprite[] glitchSprites; // array de sprites de glitch

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(PlayGlitch());
    }

    IEnumerator PlayGlitch()
    {
        float elapsedTime = 0f;

        while (elapsedTime < glitchDuration)
        {
            // troca aleatória de sprites glitch
            image.sprite = glitchSprites[Random.Range(0, glitchSprites.Length)];
            yield return new WaitForSeconds(0.05f);
            elapsedTime += 0.05f;
        }

        SceneManager.LoadScene(nextSceneName);
    }
}
