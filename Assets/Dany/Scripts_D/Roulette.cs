using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    public float rotationSpeed; // Velocidad de rotaci�n
    public float timerRotation; // Tiempo en segundos que durar� la rotaci�n
    private bool isRotating = false; // Estado de la rotaci�n

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isRotating)
        {
            StartCoroutine(RotateRoulette());
        }
    }

    IEnumerator RotateRoulette()
    {
        isRotating = true; // Iniciar rotaci�n
        float elapsedTime = 0f; // Tiempo transcurrido

        while (elapsedTime < timerRotation)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime); // Rotar el objeto
            elapsedTime += Time.deltaTime; // Actualizar tiempo transcurrido
            yield return null; // Esperar al siguiente frame
        }

        isRotating = false; // Detener rotaci�n
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Purple"))
        {
            
        }
        Debug.Log("MOradoo");
    }
}
