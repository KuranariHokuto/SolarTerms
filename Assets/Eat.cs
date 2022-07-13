using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{
    public static int count = 0;
    public GameObject endPromptCanvas;
    public GameObject it;
    // Start is called before the first frame update
    void Start()
    {
        endPromptCanvas.SetActive(false);
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
        it.SetActive(false);
        count++;
        if (count >= 1) {
            endPromptCanvas.SetActive(true);
        }
    }
}
