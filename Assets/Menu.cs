using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    Transform innerCanvas;
    Transform background;
    Transform menuCanvas;
    Transform middleCanvas;
    Transform outerCanvas;
    // Start is called before the first frame update
    void Start()
    {
        innerCanvas = transform.Find("InnerCanvas");
        background = transform.Find("Background");
        menuCanvas = transform.Find("MenuCanvas");;
        middleCanvas = transform.Find("MiddleCanvas");
        outerCanvas = transform.Find("OuterCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            float translation = Input.GetAxis("Mouse Y");
            if (translation != 0) {
                Debug.Log(translation);
                // Transform[] children = GetComponentsInChildren<Transform>();
                // foreach (Transform child in children) {
                //     if (child.name.EndsWith("Button")) child.Translate(0, translation * 5, 0);
                // }
                innerCanvas.Translate(0, translation * 10, 0);
                // 这样是不行的
                // if (innerCanvas.transform.position.y > 1200) innerCanvas.Translate(0, -2400, 0);
                background.Translate(0, translation * 6, 0);
                menuCanvas.Translate(0, translation * 6, 0);
                middleCanvas.Translate(0, translation * 4, 0);
                // if (middleCanvas.transform.position.y > 1200) middleCanvas.Translate(0, -2400, 0);
                outerCanvas.Translate(0, translation * 2, 0);
                // if (outerCanvas.transform.position.y > 1200) outerCanvas.Translate(0, -2400, 0);
            }
        }
    }
}
