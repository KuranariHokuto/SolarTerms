using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose : MonoBehaviour
{
    public Texture chooseImage;
    public Texture chosenImage;
    public GameObject foodBackground;
    public GameObject targetIndoor;
    public GameObject targetOutdoor;
    public GameObject promptCanvas1;

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
        if (ChooseFruit.chosenFruits != null && !ChooseFruit.chosenFruits.Contains(3)) {
            Debug.Log("The choice is correct.");
            promptCanvas1.SetActive(true);
            foodBackground.SetActive(false);
            targetIndoor.SetActive(true);
            targetOutdoor.SetActive(true);
        } else {
            Debug.Log("The choice is incorrect.");
            rawImage.texture = chooseImage;
        }
    }
}
