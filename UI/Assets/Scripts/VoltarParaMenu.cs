using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarParaMenu : MonoBehaviour
{
    [SerializeField] private float tempoParaVoltar = 3f; 

    void Start()
    {
        Invoke("VoltarAoMenu", tempoParaVoltar);
    }

    void VoltarAoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
