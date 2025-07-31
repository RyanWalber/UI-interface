using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicaMenu : MonoBehaviour
{
    private static MusicaMenu instancia;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += VerificarCena;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= VerificarCena;
    }

    void VerificarCena(Scene cena, LoadSceneMode modo)
    {
        if (cena.name == "gameplay")
        {
            Destroy(gameObject);
        }
    }
}
