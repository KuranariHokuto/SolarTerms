using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseVegetable : MonoBehaviour
{
    public static List<int> chosenVegetables;
    public static List<int> chosenVegetableGrids;
    public Texture notChosenToggle;
    public Texture chosenToggle;

    // Start is called before the first frame update
    void Start()
    {
        chosenVegetables = new List<int>();
        chosenVegetableGrids = new List<int>();
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
        int chosenVegetableGrid = int.Parse((string)name.Substring(13));
        if (chosenVegetableGrid < OpenFood.availableVegetables.Count) {
            int chosenVegetable = OpenFood.availableVegetables[chosenVegetableGrid];
            if (!chosenVegetables.Contains(chosenVegetable)) {
                chosenVegetables.Add(chosenVegetable);
                chosenVegetableGrids.Add(chosenVegetableGrid);
                toggles = GetComponentsInChildren<RawImage>();
                if (toggles.Length > 0) {
                    toggles[1].texture = chosenToggle;
                }
            } else {
                chosenVegetables.Remove(chosenVegetable);
                chosenVegetableGrids.Remove(chosenVegetableGrid);
                toggles = GetComponentsInChildren<RawImage>();
                if (toggles.Length > 0) {
                    toggles[1].texture = notChosenToggle;
                }
            }
        }
    }
}
