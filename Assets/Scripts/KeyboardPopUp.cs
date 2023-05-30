using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPopUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void KeyboardInput()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
    }
}
