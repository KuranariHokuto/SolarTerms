using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LichunIntro : MonoBehaviour
{
    public Texture lichunIntro0;
    public Texture lichunIntro1;
    public Texture lichunIntro2;
    public Texture lichunIntro3;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (index == 0) {
            rawImage.texture = this.lichunIntro1;
        } else if (index == 1) {
            rawImage.texture = this.lichunIntro2;
        } else if (index == 2) {
            rawImage.texture = this.lichunIntro3;
        }
        index++;
    }
}
