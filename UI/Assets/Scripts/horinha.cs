using UnityEngine;
using UnityEngine.SceneManagement;

public class fromhora : MonoBehaviour
{
    [SerializeField] private string nomeDaProximaCena = "hora"; // próxima cena
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
