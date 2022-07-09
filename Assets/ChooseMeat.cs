using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMeat : MonoBehaviour
{
    public static int chosenMeat = -1;
    public static int chosenMeatLocation = -1;
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
        RawImage[] toggles;
        if (chosenMeatLocation != -1) {
            GameObject meatGrid = GameObject.Find("MeatGrid" + chosenMeatLocation);
            toggles = meatGrid.GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0 && toggles[1].texture.Equals(chosenToggle)) {
                toggles[1].texture = notChosenToggle;
            }
        }
        chosenMeatLocation = int.Parse((string)name.Substring(8));
        Debug.Log("Choose " + OpenFood.availableMeats[chosenMeatLocation]);
        chosenMeat = OpenFood.availableMeats[chosenMeatLocation];
        toggles = GetComponentsInChildren<RawImage>();
        if (toggles.Length > 0) {
            toggles[1].texture = chosenToggle;
        }
    }
}
