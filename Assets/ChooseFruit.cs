using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseFruit : MonoBehaviour
{
    public static List<int> chosenFruits;
    public static List<int> chosenFruitGrids;
    public Texture notChosenToggle;
    public Texture chosenToggle;

    // Start is called before the first frame update
    void Start()
    {
        chosenFruits = new List<int>();
        chosenFruitGrids = new List<int>();
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
        RawImage[] toggles;
        // if (chosenFruitGrid != -1) {
        //     GameObject fruitGrid = GameObject.Find("FruitGrid" + chosenFruitGrid);
        //     toggles = fruitGrid.GetComponentsInChildren<RawImage>();
        //     if (toggles.Length > 0 && toggles[1].texture.Equals(chosenToggle)) {
        //         toggles[1].texture = notChosenToggle;
        //     }
        // }
        int chosenFruitGrid = int.Parse((string)name.Substring(9));
        int chosenFruit = OpenFood.availableFruits[chosenFruitGrid];
        if (!chosenFruits.Contains(chosenFruit)) {
            chosenFruits.Add(chosenFruit);
            chosenFruitGrids.Add(chosenFruitGrid);
            toggles = GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0) {
                toggles[1].texture = chosenToggle;
            }
        } else {
            chosenFruits.Remove(chosenFruit);
            chosenFruitGrids.Remove(chosenFruitGrid);
            toggles = GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0) {
                toggles[1].texture = notChosenToggle;
            }
        }
    }
}
