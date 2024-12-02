using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciones : MonoBehaviour
{
    public int vidas = 4;
    public int intentosPorPregunta = 2;

    private int intentosRestantes;
    private string respuestaCorrecta;

    public string texto; 
    public string respuestaCorrecta; 
    public string[] opciones;

    void Start()
    {
        intentosRestantes = intentosPorPregunta;
        GenerarNuevaPregunta();
    }

    void GenerarNuevaPregunta()
    {

        respuestaCorrecta = "respuesta_correcta";

        intentosRestantes = intentosPorPregunta;
    }

    public void VerificarRespuesta(string respuesta)
    {
        if (respuesta == respuestaCorrecta)
        {
            GenerarNuevaPregunta();
        }
        else
        {
            intentosRestantes--;

            if (intentosRestantes > 0)
            {
                // no c
            }
            else
            {

                PerderVida();
            }
        }
    }

    void PerderVida()
    {
        vidas--;

        if (vidas > 0)
        {

            GenerarNuevaPregunta();
        }
        else
        {

            FinDelJuego();
        }
    }

    void FinDelJuego()
    {

    }
}