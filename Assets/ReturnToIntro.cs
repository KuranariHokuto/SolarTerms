using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToIntro : MonoBehaviour
{
    public GameObject introCanvas;
    public GameObject indoorCanvas;
    public GameObject outdoorCanvas;
    public GameObject targetIndoor;
    public GameObject targetOutdoor;
    public GameObject target0;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject target6;

    // Start is called before the first frame update
    void Start()
    {
        targetIndoor.SetActive(false);
        targetOutdoor.SetActive(false);
        target0.SetActive(true);
        target1.SetActive(true);
        target2.SetActive(true);
        target3.SetActive(true);
        target4.SetActive(true);
        target5.SetActive(true);
        target6.SetActive(true);
        if (LichunIntro.index == 0) {
            introCanvas.SetActive(true);
            outdoorCanvas.SetActive(false);
            indoorCanvas.SetActive(false);
        }
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
