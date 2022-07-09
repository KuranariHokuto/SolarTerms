using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenFood : MonoBehaviour
{
    public GameObject foodBackground;
    public GameObject[] fruitGrids;
    public GameObject[] vegetableGrids;
    public GameObject[] meatGrids;
    public GameObject[] cornGrids;
    public Texture[] foodImages;
    public int[] availableFoods;
    public int currentFruitCount;
    public int currentVegetableCount;
    public int currentMeatCount;
    public int currentCornCount;
    public bool inited;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 16; i++) {
            fruitGrids[i] = GameObject.Find("FruitGrid" + i);
        }
        for (int i = 0; i < 16; i++) {
            vegetableGrids[i] = GameObject.Find("VegetableGrid" + i);
        }
        for (int i = 0; i < 16; i++) {
            meatGrids[i] = GameObject.Find("MeatGrid" + i);
        }
        for (int i = 0; i < 16; i++) {
            cornGrids[i] = GameObject.Find("CornGrid" + i);
        }
        currentFruitCount = 0;
        currentVegetableCount = 0;
        currentMeatCount = 0;
        currentCornCount = 0;
        inited = false;
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
        foodBackground.SetActive(true);
        if (!inited) InitFood();
    }

    public void InitFood()
    {
        AddFood(1, "Fruit");
        AddFood(3, "Fruit");
        inited = true;
    }

    public void AddFood(int foodIndex, string foodType)
    {
        if ("Fruit".Equals(foodType) && currentFruitCount < 16) {
            RawImage rawImage = fruitGrids[currentFruitCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentFruitCount++;
        } else if ("Vegetable".Equals(foodType) && currentVegetableCount < 16) {
            RawImage rawImage = vegetableGrids[currentVegetableCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentVegetableCount++;
        } else if ("Meat".Equals(foodType) && currentMeatCount < 16) {
            RawImage rawImage = meatGrids[currentMeatCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentMeatCount++;
        } else if ("Corn".Equals(foodType) && currentCornCount < 16) {
            RawImage rawImage = cornGrids[currentCornCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentCornCount++;
        }
    }
}
