using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    public bool isFinished = false;
    public static DetectCollider Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Purple"))
        {
            if (isFinished) 
            {
                Debug.Log("MOradoo");
            }
            
        }

        if (collision.CompareTag("Blue"))
        {
            if (isFinished)
            {
                Debug.Log("Blue");
            }

        }

        if (collision.CompareTag("Green"))
        {
            if (isFinished)
            {
                Debug.Log("Green");
            }

        }

    }

}
