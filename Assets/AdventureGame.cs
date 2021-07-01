using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{   
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "You wake up from a nap at your desk, a nagging dream slowly fading from your mind.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
