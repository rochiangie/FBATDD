using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextoHipervinculo : MonoBehaviour, IPointerClickHandler
{
    private TextMeshProUGUI p_texto;
    private Canvas p_canvas;

    void Awake()
    {
        p_texto = GetComponent<TextMeshProUGUI>();
        // Buscamos el canvas para que el cálculo de la posición del mouse sea exacto
        p_canvas = GetComponentInParent<Canvas>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Detectamos qué link se presionó basado en la posición del mouse
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(p_texto, eventData.position, p_canvas.worldCamera);

        if (linkIndex != -1) // -1 significa que no se hizo clic en un link
        {
            TMP_LinkInfo linkInfo = p_texto.textInfo.linkInfo[linkIndex];

            // El ID que pongas en el tag <link> será el nombre de la escena
            string nombreEscena = linkInfo.GetLinkID();

            Debug.Log("Cargando escena desde hipertexto: " + nombreEscena);
            SceneManager.LoadScene(nombreEscena);
        }
    }
}