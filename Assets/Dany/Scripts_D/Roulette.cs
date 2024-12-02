using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    public float rotationSpeed; 
    public float minRotationTime = 1f; 
    public float maxRotationTime = 5f; 
    private bool isRotating = false; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isRotating)
        {
            timerRotation = Random.Range(minRotationTime, maxRotationTime); 
            StartCoroutine(RotateRoulette());
            DetectCollider.Instance.isFinished = false;
        }
    }

    private float timerRotation;

    IEnumerator RotateRoulette()
    {
        isRotating = true; 
        float elapsedTime = 0f; 

        while (elapsedTime < timerRotation)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime); 
            elapsedTime += Time.deltaTime; 
            yield return null; 
        }

        isRotating = false; 
        DetectCollider.Instance.isFinished = true;
    }
}
