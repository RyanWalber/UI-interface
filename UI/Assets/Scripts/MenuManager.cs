using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string Jornal;


    public void NewGame()
    {
        SceneManager.LoadScene(Jornal);
    }
}
