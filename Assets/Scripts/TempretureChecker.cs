using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
public class Porridge : MonoBehaviour
{
    [SerializeField] private float tempreature;
    private void Start()
    {
        tempreature = 100;
    }
    private void Update()
    {
        tempreature = tempreature - Time.deltaTime;

        if (tempreature > 70)
        {
            Debug.Log("The tempreature is too hot" + (int)tempreature);
        }
        else if (tempreature < 40)
        {
            Debug.Log("The tempreature is too clod" + (int)tempreature);
        }
        else
        {
            Debug.Log("The tempreature is just right" + (int)tempreature);
        }

    }

}

