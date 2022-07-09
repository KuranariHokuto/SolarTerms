using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseVegetable : MonoBehaviour
{
    public static int chosenVegetable = -1;
    public static int chosenVegetableLocation = -1;
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
        if (chosenVegetableLocation != -1) {
            GameObject vegetableGrid = GameObject.Find("VegetableGrid" + chosenVegetableLocation);
            toggles = vegetableGrid.GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0 && toggles[1].texture.Equals(chosenToggle)) {
                toggles[1].texture = notChosenToggle;
            }
        }
        chosenVegetableLocation = int.Parse((string)name.Substring(13));
        Debug.Log("Choose " + OpenFood.availableVegetables[chosenVegetableLocation]);
        chosenVegetable = OpenFood.availableVegetables[chosenVegetableLocation];
        toggles = GetComponentsInChildren<RawImage>();
        if (toggles.Length > 0) {
            toggles[1].texture = chosenToggle;
        }
    }
}
