using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaEnPuerta : MonoBehaviour
{
    public string nombreDeLaEscenaACargar; // Nombre de la escena a la que quieres cambiar

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Puerta")) // Verifica si es la puerta con el Tag asignado
        {
            SceneManager.LoadScene(nombreDeLaEscenaACargar);
        }
    }
}
