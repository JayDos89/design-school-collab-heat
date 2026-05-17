using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using NUnit;
using UnityEngine.Audio;
public class InventoryController : MonoBehaviour
{
    public List<string> inventory = new List<string>();
    public List<string> inventoryItems = new List<string>();

    [SerializeField] private TextMeshProUGUI inventoryText;
    [SerializeField] private GameObject inventoryWindow;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //inventory.Add("Horseshoe");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(string item)
    {
        inventory.Add(item);
        Debug.Log("Added " + item + " to inventory.");
    }

    public void ShowInventory()
    {
        foreach (string item in inventory)
        {
            inventoryText.text = string.Join("\n", inventory);
            Debug.Log("Inventory Item: " + item);
        }
        Debug.Log("Inventory: " + string.Join(", ", inventory));
    }
}
