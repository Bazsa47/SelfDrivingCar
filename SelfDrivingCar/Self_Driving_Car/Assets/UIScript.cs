using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    public GeneticManager greenManager;
    public RedGeneticManager redManager;
    public TextMeshProUGUI redText, greenText, timeScale;
    private int redGeneration, redGenome, greenGeneration, greenGenome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        redGeneration = redManager.currentGeneration;
        redGenome = redManager.currentGenome;
        greenGeneration = greenManager.currentGeneration;
        greenGenome = greenManager.currentGenome;
        redText.text = string.Format("Generation: {0} Genome: {1}",redGeneration,redGenome);
        greenText.text = string.Format("Generation: {0} Genome: {1}", greenGeneration, greenGenome);

        if (Input.GetKeyDown(KeyCode.DownArrow) && Time.timeScale > 1)
        {
            Time.timeScale -= 0.25f;
            timeScale.text = "Time scale: " + Time.timeScale+"x";
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && Time.timeScale <= 20){
            Time.timeScale += 0.25f;
            timeScale.text = "Time scale: " + Time.timeScale+ "x";
        }
    }
}
