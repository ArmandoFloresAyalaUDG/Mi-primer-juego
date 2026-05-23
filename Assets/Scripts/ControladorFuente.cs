using UnityEngine;
using TMPro;

public class ControladorFuente : MonoBehaviour
{
    public TextMeshProUGUI textoObjetivo;
    private bool tamanoGrande = false;
    private float tamanoNormal = 36f;
    private float tamanoAumentado = 60f;

    public void CambiarTamanoFuente()
    {
        if (tamanoGrande)
        {
            textoObjetivo.fontSize = tamanoNormal;
            tamanoGrande = false;
        }
        else
        {
            textoObjetivo.fontSize = tamanoAumentado;
            tamanoGrande = true;
        }
    }
}