using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LichunIntro : MonoBehaviour
{
    public GameObject lichunIntro;
    public Texture[] lichunIntros;
    public int size;
    public int index = 0;
    public GameObject introCanvas;
    public GameObject indoorCanvas;
    // Start is called before the first frame update
    void Start()
    {
        size = lichunIntros.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && RectTransformUtility.RectangleContainsScreenPoint(GetComponent<RectTransform>(), Input.mousePosition)) {
            Change();
        }
    }

    void Change()
    {
        RawImage rawImage = lichunIntro.GetComponent<RawImage>();
        if (index < size - 1) {
            rawImage.texture = lichunIntros[index + 1];
            index++;
        } else {
            indoorCanvas.SetActive(true);
            introCanvas.SetActive(false);
        }
    }

    public void Reset()
    {
        RawImage rawImage = lichunIntro.GetComponent<RawImage>();
        rawImage.texture = lichunIntros[0];
        index = 0;
    }
}
