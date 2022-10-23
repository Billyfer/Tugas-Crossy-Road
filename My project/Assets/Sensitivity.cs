using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sensitivity : MonoBehaviour
{
     public Slider Sensitiv;

    private void Start()
        {
            
        }
    public void Sensi(float value)
        {
            value = value * 80 - 80;


            Debug.Log("Sensitivity: " + value);
        }
}
