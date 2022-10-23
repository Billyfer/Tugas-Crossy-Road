using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    List<int> width = new List<int>
    {
        568,
        960,
        1280,
        1920,

    };
    List<int> height = new List<int>
    {
        320,
        540,
        720,
        1080
    };

    public void SetReso(int index)
    {
        int w = width [index];
        int h = height [index];
        Screen.SetResolution(width[index], height[index], true);

        Debug.Log("Set Resolution" + w + "x" + h );
    }




}
