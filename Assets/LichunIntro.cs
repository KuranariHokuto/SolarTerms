using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LichunIntro : MonoBehaviour
{
    public GameObject lichunIntro;
    public Texture[] lichunIntros;
    public int size;
    public static int index = 0;
    public GameObject introCanvas;
    public GameObject indoorCanvas;
    public GameObject promptCanvas;
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
        if (index == 0) {
            rawImage.texture = lichunIntros[index + 1];
            transform.Translate(new Vector3(-500, 0, 0), Space.Self);
            index++;
        } else if (index == 1) {
            rawImage.texture = lichunIntros[index + 1];
            transform.Translate(new Vector3(500, 0, 0), Space.Self);
            index++;
        } else {
            indoorCanvas.SetActive(true);
            promptCanvas.SetActive(true);
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
