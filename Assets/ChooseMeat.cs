using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMeat : MonoBehaviour
{
    public static List<int> chosenMeats;
    public static List<int> chosenMeatGrids;
    public Texture notChosenToggle;
    public Texture chosenToggle;

    // Start is called before the first frame update
    void Start()
    {
        chosenMeats = new List<int>();
        chosenMeatGrids = new List<int>();
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
        int chosenMeatGrid = int.Parse((string)name.Substring(8));
        if (chosenMeatGrid < OpenFood.availableMeats.Count) {
            int chosenMeat = OpenFood.availableMeats[chosenMeatGrid];
            if (!chosenMeats.Contains(chosenMeat)) {
                chosenMeats.Add(chosenMeat);
                chosenMeatGrids.Add(chosenMeatGrid);
                toggles = GetComponentsInChildren<RawImage>();
                if (toggles.Length > 0) {
                    toggles[1].texture = chosenToggle;
                }
            } else {
                chosenMeats.Remove(chosenMeat);
                chosenMeatGrids.Remove(chosenMeatGrid);
                toggles = GetComponentsInChildren<RawImage>();
                if (toggles.Length > 0) {
                    toggles[1].texture = notChosenToggle;
                }
            }
        }
    }
}
