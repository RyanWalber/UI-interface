using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    [SerializeField] private string nomeDaProximaCena = "Gameplay";
    [SerializeField] private float tempoDeEspera = 2f;

    void Start()
    {
        Invoke("CarregarProximaCena", tempoDeEspera);
    }

    void CarregarProximaCena()
    {
        SceneManager.LoadScene(nomeDaProximaCena);
    }
}
