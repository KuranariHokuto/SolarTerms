using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{
    public static int count = 0;
    public GameObject endPrompt;
    // Start is called before the first frame update
    void Start()
    {
        endPrompt.SetActive(false);
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
        gameObject.SetActive(false);
        count++;
        if (count == 5) {
            endPrompt.SetActive(true);
        }
    }
}
