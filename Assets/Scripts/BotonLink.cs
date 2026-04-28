using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonLink : MonoBehaviour
{
    /// <summary>
    /// Este método recibe el nombre de la escena como parámetro.
    /// Esto permite que cada botón en el Inspector tenga un destino diferente
    /// usando el mismo script y el mismo objeto.
    /// </summary>
    /// <param name="nombreEscena">El nombre exacto de la escena a cargar.</param>
    public void CambiarEscena(string nombreEscena)
    {
        if (!string.IsNullOrEmpty(nombreEscena))
        {
            SceneManager.LoadScene(nombreEscena);
        }
        else
        {
            Debug.LogError("El nombre de la escena está vacío. Revisa el Inspector del Botón.");
        }
    }
}