using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodType : MonoBehaviour
{
    public GameObject fruitCanvas;
    public GameObject vegetableCanvas;
    public GameObject meatCanvas;
    public GameObject cornCanvas;

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
        if ("Fruit".Equals(name)) {
            fruitCanvas.SetActive(true);
            vegetableCanvas.SetActive(false);
            meatCanvas.SetActive(false);
            cornCanvas.SetActive(false);
        } else if ("Vegetable".Equals(name)) {
            fruitCanvas.SetActive(false);
            vegetableCanvas.SetActive(true);
            meatCanvas.SetActive(false);
            cornCanvas.SetActive(false);
        } else if ("Meat".Equals(name)) {
            fruitCanvas.SetActive(false);
            vegetableCanvas.SetActive(false);
            meatCanvas.SetActive(true);
            cornCanvas.SetActive(false);
        } else if ("Corn".Equals(name)) {
            fruitCanvas.SetActive(false);
            vegetableCanvas.SetActive(false);
            meatCanvas.SetActive(false);
            cornCanvas.SetActive(true);
        }
    }

    public void ChangeByName(string foodType) {
        if ("Fruit".Equals(foodType)) {
            fruitCanvas.SetActive(true);
            vegetableCanvas.SetActive(false);
            meatCanvas.SetActive(false);
            cornCanvas.SetActive(false);
        } else if ("Vegetable".Equals(foodType)) {
            fruitCanvas.SetActive(false);
            vegetableCanvas.SetActive(true);
            meatCanvas.SetActive(false);
            cornCanvas.SetActive(false);
        } else if ("Meat".Equals(foodType)) {
            fruitCanvas.SetActive(false);
            vegetableCanvas.SetActive(false);
            meatCanvas.SetActive(true);
            cornCanvas.SetActive(false);
        } else if ("Corn".Equals(foodType)) {
            fruitCanvas.SetActive(false);
            vegetableCanvas.SetActive(false);
            meatCanvas.SetActive(false);
            cornCanvas.SetActive(true);
        }
    }
}
