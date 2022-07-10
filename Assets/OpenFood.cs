using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenFood : MonoBehaviour
{
    public GameObject foodBackground;
    public GameObject cookAndEat;
    public GameObject[] fruitGrids;
    public GameObject[] vegetableGrids;
    public GameObject[] meatGrids;
    public GameObject[] cornGrids;
    public Texture[] foodImages;
    public static List<int> availableFruits;
    public static List<int> availableVegetables;
    public static List<int> availableMeats;
    public static List<int> availableCorns;
    public static int currentFruitCount;
    public static int currentVegetableCount;
    public static int currentMeatCount;
    public static int currentCornCount;
    public GameObject fruitCanvas;
    public GameObject vegetableCanvas;
    public GameObject meatCanvas;
    public GameObject cornCanvas;
    public static bool inited;

    // Start is called before the first frame update
    void Start()
    {
        fruitGrids = new GameObject[12];
        vegetableGrids = new GameObject[12];
        meatGrids = new GameObject[12];
        cornGrids = new GameObject[12];
        availableFruits = new List<int>();
        availableVegetables = new List<int>();
        availableMeats = new List<int>();
        availableCorns = new List<int>();
        currentFruitCount = 0;
        currentVegetableCount = 0;
        currentMeatCount = 0;
        currentCornCount = 0;
        inited = false;
        foodBackground.SetActive(false);
        cookAndEat.SetActive(false);
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
        fruitCanvas.SetActive(true);
        vegetableCanvas.SetActive(true);
        meatCanvas.SetActive(true);
        cornCanvas.SetActive(true);
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
        for (int i = 0; i < 4; i++) {
            availableFruits.Add(i);
        }
        for (int i = 4; i < 8; i++) {
            availableVegetables.Add(i);
        }
        for (int i = 8; i < 11; i++) {
            availableMeats.Add(i);
        }
        for (int i = 11; i < 12; i++) {
            availableCorns.Add(i);
        }
        for (int i = 0; i < availableFruits.Count; i++) {
            AddFood(availableFruits[i], "Fruit");
        }
        for (int i = 0; i < availableVegetables.Count; i++) {
            AddFood(availableVegetables[i], "Vegetable");
        }
        for (int i = 0; i < availableMeats.Count; i++) {
            AddFood(availableMeats[i], "Meat");
        }
        for (int i = 0; i < availableCorns.Count; i++) {
            AddFood(availableCorns[i], "Corn");
        }
        vegetableCanvas.SetActive(false);
        meatCanvas.SetActive(false);
        cornCanvas.SetActive(false);
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
