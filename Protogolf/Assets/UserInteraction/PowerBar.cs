using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PowerBar : MonoBehaviour
{
    [SerializeField]
    public clubBase club;

    private bool isShooting = false;
    private Slider powerbar;
    

    // Start is called before the first frame update
    void Start()
    {
        //Obtenemos la powerbar
        powerbar = GameObject.Find("PowerBar").GetComponent<Slider>();
        if( powerbar == null) 
        {
            Debug.Log("No se pudo obtener el powerbar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isShooting = !isShooting;
        }

        if (isShooting)
        {
            powerbar.value += Time.deltaTime * club.control;
        }
    }
}
