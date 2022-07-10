using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCorn : MonoBehaviour
{
    public static List<int> chosenCorns;
    public static List<int> chosenCornGrids;
    public Texture notChosenToggle;
    public Texture chosenToggle;

    // Start is called before the first frame update
    void Start()
    {
        chosenCorns = new List<int>();
        chosenCornGrids = new List<int>();
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
        int chosenCornGrid = int.Parse((string)name.Substring(9));
        int chosenCorn = OpenFood.availableCorns[chosenCornGrid];
        if (!chosenCorns.Contains(chosenCorn)) {
            chosenCorns.Add(chosenCorn);
            chosenCornGrids.Add(chosenCornGrid);
            toggles = GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0) {
                toggles[1].texture = chosenToggle;
            }
        } else {
            chosenCorns.Remove(chosenCorn);
            chosenCornGrids.Remove(chosenCornGrid);
            toggles = GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0) {
                toggles[1].texture = notChosenToggle;
            }
        }
    }
}
