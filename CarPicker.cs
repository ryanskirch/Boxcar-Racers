using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CarPicker : MonoBehaviour
{

    public GameObject carbonCar;
    public GameObject boxCar;
    public GameObject metalCar;
    public GameObject smoothCar;
    public GameObject canvas;


    public void CarbonPicked()
    {
            carbonCar.SetActive(true);
            canvas.SetActive(false);
    }
    
    public void BoxPicked()
    {
            boxCar.SetActive(true);
            canvas.SetActive(false);
    }

    public void MetalPicked()
    {
            metalCar.SetActive(true);
            canvas.SetActive(false);
    }

    public void SmoothPicked()
    {
            smoothCar.SetActive(true);
            canvas.SetActive(false);
    }

}
