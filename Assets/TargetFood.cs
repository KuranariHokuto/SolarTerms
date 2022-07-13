using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetFood : MonoBehaviour
{
    public static List<int> targetedFoods;
    public GameObject food;
    public GameObject foodType;

    // Start is called before the first frame update
    void Start()
    {
        targetedFoods = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Target0() {
        if (!targetedFoods.Contains(0)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(0);
            OpenFood.availableFruits.Add(0);
            food.GetComponent<OpenFood>().AddFood(0, "Fruit");
            foodType.GetComponent<FoodType>().ChangeByName("Fruit");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target1() {
        if (!targetedFoods.Contains(1)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(1);
            OpenFood.availableFruits.Add(1);
            food.GetComponent<OpenFood>().AddFood(1, "Fruit");
            foodType.GetComponent<FoodType>().ChangeByName("Fruit");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target2() {
        if (!targetedFoods.Contains(2)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(2);
            OpenFood.availableFruits.Add(2);
            food.GetComponent<OpenFood>().AddFood(2, "Fruit");
            foodType.GetComponent<FoodType>().ChangeByName("Fruit");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target3() {
        if (!targetedFoods.Contains(3)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(3);
            OpenFood.availableFruits.Add(3);
            food.GetComponent<OpenFood>().AddFood(3, "Fruit");
            foodType.GetComponent<FoodType>().ChangeByName("Fruit");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target4() {
        if (!targetedFoods.Contains(4)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(4);
            OpenFood.availableVegetables.Add(4);
            food.GetComponent<OpenFood>().AddFood(4, "Vegetable");
            foodType.GetComponent<FoodType>().ChangeByName("Vegetable");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target5() {
        if (!targetedFoods.Contains(5)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(5);
            OpenFood.availableVegetables.Add(5);
            food.GetComponent<OpenFood>().AddFood(5, "Vegetable");
            foodType.GetComponent<FoodType>().ChangeByName("Vegetable");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target6() {
        if (!targetedFoods.Contains(6)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(6);
            OpenFood.availableVegetables.Add(6);
            food.GetComponent<OpenFood>().AddFood(6, "Vegetable");
            foodType.GetComponent<FoodType>().ChangeByName("Vegetable");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target7() {
        if (!targetedFoods.Contains(7)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(7);
            OpenFood.availableVegetables.Add(7);
            food.GetComponent<OpenFood>().AddFood(7, "Vegetable");
            foodType.GetComponent<FoodType>().ChangeByName("Vegetable");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target8() {
        if (!targetedFoods.Contains(8)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(8);
            OpenFood.availableMeats.Add(8);
            food.GetComponent<OpenFood>().AddFood(8, "Meat");
            foodType.GetComponent<FoodType>().ChangeByName("Meat");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target9() {
        if (!targetedFoods.Contains(9)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(9);
            OpenFood.availableMeats.Add(9);
            food.GetComponent<OpenFood>().AddFood(9, "Meat");
            foodType.GetComponent<FoodType>().ChangeByName("Meat");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target10() {
        if (!targetedFoods.Contains(10)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(10);
            OpenFood.availableMeats.Add(10);
            food.GetComponent<OpenFood>().AddFood(10, "Meat");
            foodType.GetComponent<FoodType>().ChangeByName("Meat");
            food.GetComponent<OpenFood>().Flash();
        }
    }
    public void Target11() {
        if (!targetedFoods.Contains(11)) {
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
            targetedFoods.Add(11);
            OpenFood.availableCorns.Add(11);
            food.GetComponent<OpenFood>().AddFood(11, "Corn");
            foodType.GetComponent<FoodType>().ChangeByName("Corn");
            food.GetComponent<OpenFood>().Flash();
        }
    }
}
