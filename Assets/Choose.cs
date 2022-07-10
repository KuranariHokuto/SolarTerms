using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose : MonoBehaviour
{
    public Texture chooseImage;
    public Texture chosenImage;
    public GameObject foodBackground;

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
        RawImage rawImage = GetComponent<RawImage>();
        rawImage.texture = chosenImage;
        if (!ChooseFruit.chosenFruits.Contains(3)) {
            Debug.Log("The choice is correct.");
            foodBackground.SetActive(false);
        } else {
            Debug.Log("The choice is incorrect.");
            rawImage.texture = chooseImage;
        }
    }
}
