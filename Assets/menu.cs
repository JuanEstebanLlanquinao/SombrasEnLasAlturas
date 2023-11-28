using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string nombreDeLaEscenaACargar; // Nombre de la escena a la que quieres cambiar

    public void CambiarAEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaACargar);
    }
}
