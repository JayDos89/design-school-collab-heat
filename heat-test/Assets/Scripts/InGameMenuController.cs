using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InGameMenuController : MonoBehaviour
{
    public GameObject IGMenuCanvas; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        { 
            ToggleSwitch();
            IGMenuCanvas.SetActive(toggle);
        }
    }

    bool toggle = false;
    public void ToggleSwitch()
    {
        toggle = !toggle;
        Debug.Log(toggle);
    }

}

