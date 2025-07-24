using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    public Image telaCamera; 
    public Sprite[] camerasSprites; 

    
    public void MudarCamera(int index)
    {
        telaCamera.sprite = camerasSprites[index];
    }
}
