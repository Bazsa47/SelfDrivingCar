using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject redCar;
    public GameObject greenCar;
    public Camera greenCamera;
    float redCarFitness, greenCarFitness;

     void Start()
    {

        greenCamera.enabled = true;
    }
    void FixedUpdate()
    {
        redCarFitness = redCar.GetComponent<RedCarController>().overallFitness;
        greenCarFitness = greenCar.GetComponent<CarController>().overallFitness;

        if(redCarFitness > greenCarFitness)
        {
            greenCamera.enabled = false;
        }
        else
        {
            greenCamera.enabled = true;
        }
    }
}
