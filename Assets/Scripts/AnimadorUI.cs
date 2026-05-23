using UnityEngine;
using UnityEngine.UI;

public class AnimadorUI : MonoBehaviour
{
    public Texture2D[] frames;
    public float velocidad = 12f;

    private RawImage rawImage;
    private float timer;
    private int frameActual;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f / velocidad)
        {
            timer = 0f;
            frameActual = (frameActual + 1) % frames.Length;
            rawImage.texture = frames[frameActual];
        }
    }
}