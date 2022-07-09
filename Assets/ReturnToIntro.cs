using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToIntro : MonoBehaviour
{
    public GameObject introCanvas;
    public GameObject indoorCanvas;
    public GameObject outdoorCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
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
        introCanvas.SetActive(true);
        GameObject.Find("NextStep").GetComponent<LichunIntro>().Reset();
        outdoorCanvas.SetActive(false);
        indoorCanvas.SetActive(false);
    }
}
