using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodType : MonoBehaviour
{
    public static GameObject fruitCanvas;
    public static GameObject vegetableCanvas;
    public static GameObject meatCanvas;
    public static GameObject cornCanvas;

    // Start is called before the first frame update
    void Start()
    {
        fruitCanvas = GameObject.Find("FruitCanvas");
        vegetableCanvas = GameObject.Find("VegetableCanvas");
        meatCanvas = GameObject.Find("MeatCanvas");
        cornCanvas = GameObject.Find("CronCanvas");
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

    public static void ChangeByName(string foodType) {
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
