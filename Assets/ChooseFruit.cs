using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseFruit : MonoBehaviour
{
    public static int chosenFruit = -1;
    public static int chosenFruitLocation = -1;
    public Texture notChosenToggle;
    public Texture chosenToggle;

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
        chosenFruitLocation = int.Parse((string)name.Substring(9));
        Debug.Log("Choose " + OpenFood.availableFruits[chosenFruitLocation]);
        chosenFruit = OpenFood.availableFruits[chosenFruitLocation];
        RawImage[] toggles = GetComponentsInChildren<RawImage>();
        if (toggles.Length > 0) {
            toggles[1].texture = chosenToggle;
        }
        for (int i = 0; i < 12; i++) {
            GameObject fruitGrid = GameObject.Find("FruitGrid" + i);
            toggles = fruitGrid.GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0 && toggles[1].texture.Equals(chosenToggle)) {
                toggles[1].texture = notChosenToggle;
            }
        }
    }
}
