using UnityEngine;

public class CerrarApp : MonoBehaviour
{
    /// <summary>
    /// Cierra la aplicación o detiene el modo Play en el Editor.
    /// </summary>
    public void Salir()
    {
        Debug.Log("Saliendo de la aplicación...");

        // Si estamos ejecutando dentro del Editor de Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Si es una build real (PC, Android, etc.)
            Application.Quit();
#endif
    }
}