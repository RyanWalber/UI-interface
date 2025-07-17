using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAutoLoader : MonoBehaviour
{
    [SerializeField] private string nomeDaProximaCena = "chiado transição"; // nome exato da próxima cena
    [SerializeField] private float tempoDeEspera = 5f; // tempo em segundos antes de trocar

    void Start()
    {
        Invoke("CarregarProximaCena", tempoDeEspera);
    }

    void CarregarProximaCena()
    {
        SceneManager.LoadScene(nomeDaProximaCena);
    }
}
