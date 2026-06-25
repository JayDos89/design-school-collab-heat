using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InGameMenuController : MonoBehaviour
{
    public GameObject MenuCanvas; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        int toggle = 0;
        
        if (Keyboard.current.oKey.wasPressedThisFrame && toggle == 0)
        { 
            Debug.Log("escape key worked");
            MenuCanvas.SetActive(true);
            
        }
        if (Keyboard.current.oKey.wasPressedThisFrame && toggle == 0)
        { 
            Debug.Log("escape key worked");
            MenuCanvas.SetActive(false);
            
        }
       
    }
}
