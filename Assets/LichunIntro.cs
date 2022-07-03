using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LichunIntro : MonoBehaviour
{
    public Texture[] lichunIntros;
    public int size;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        size = lichunIntros.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Change();
        }
    }

    void Change()
    {
        RawImage rawImage = GetComponent<RawImage>();
        if (index < size - 1) {
            rawImage.texture = lichunIntros[index + 1];
            index++;
        }
    }
}
