using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class clubBase : MonoBehaviour
{
    //Nombre
    [SerializeField]
    public string nombre = "Driver inicial";

    //Descripción
    public string descripcion = "Driver básico, seguramente lo uses hasta que encuentres algo mejor(Tirado en la basura?)";

    //Distancia máxima del palo
    public float fuerza = 100.0f;

    //Velocidad de la barra deslizante
    public float control = 1000.0f;

    //Precisión del tiro
    public float precision = 100.0f;
}
