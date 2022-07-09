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
    public ArrayList availableFruits;
    public ArrayList availableVegetables;
    public ArrayList availableMeats;
    public ArrayList availableCorns;
    public int currentFruitCount;
    public int currentVegetableCount;
    public int currentMeatCount;
    public int currentCornCount;
    public bool inited;

    // Start is called before the first frame update
    void Start()
    {
        fruitGrids = new GameObject[12];
        vegetableGrids = new GameObject[12];
        meatGrids = new GameObject[12];
        cornGrids = new GameObject[12];
        availableFruits = new ArrayList();
        availableVegetables = new ArrayList();
        availableMeats = new ArrayList();
        availableCorns = new ArrayList();
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
        for (int i = 0; i < 12; i++) {
            fruitGrids[i] = GameObject.Find("FruitGrid" + i);
        }
        for (int i = 0; i < 12; i++) {
            vegetableGrids[i] = GameObject.Find("VegetableGrid" + i);
        }
        for (int i = 0; i < 12; i++) {
            meatGrids[i] = GameObject.Find("MeatGrid" + i);
        }
        for (int i = 0; i < 12; i++) {
            cornGrids[i] = GameObject.Find("CornGrid" + i);
        }
        availableFruits.Add(2);
        AddFood(0, "Fruit");
        AddFood(2, "Fruit");
        inited = true;
    }

    public void AddFood(int foodIndex, string foodType)
    {
        if ("Fruit".Equals(foodType) && currentFruitCount < 12) {
            RawImage rawImage = fruitGrids[currentFruitCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentFruitCount++;
        } else if ("Vegetable".Equals(foodType) && currentVegetableCount < 12) {
            RawImage rawImage = vegetableGrids[currentVegetableCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentVegetableCount++;
        } else if ("Meat".Equals(foodType) && currentMeatCount < 12) {
            RawImage rawImage = meatGrids[currentMeatCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentMeatCount++;
        } else if ("Corn".Equals(foodType) && currentCornCount < 12) {
            RawImage rawImage = cornGrids[currentCornCount].GetComponent<RawImage>();
            rawImage.texture = foodImages[foodIndex];
            currentCornCount++;
        }
    }
}
