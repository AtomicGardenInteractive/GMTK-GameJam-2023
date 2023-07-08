using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private Text takesText;
    int totalTakes = 0;

    public void addToTakesText()
    {
        totalTakes++;
        takesText.text = "Takes: " + totalTakes.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        takesText.text = "Takes: " + totalTakes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
