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

    //Descripci�n
    public string descripcion = "Driver b�sico, seguramente lo uses hasta que encuentres algo mejor(Tirado en la basura?)";

    //Distancia m�xima del palo
    public float fuerza = 100.0f;

    //Velocidad de la barra deslizante
    public float control = 1000.0f;

    //Precisi�n del tiro
    public float precision = 100.0f;
}
