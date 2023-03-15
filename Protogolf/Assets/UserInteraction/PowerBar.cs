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
    private bool isPowerAum = true;

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

            if( isPowerAum )
            {
                powerbar.value += Time.deltaTime * club.control;
            } else { powerbar.value -= Time.deltaTime * club.control; }

            if( powerbar.value >= 1000 )
            {
                isPowerAum = false;
            } 
            if( powerbar.value <= 0)
            {
                isPowerAum = true;
            }
        }

        if( powerbar.value <= 0)
        {
            isShooting=false;
        }
        Debug.Log(powerbar.value);
        Debug.Log(isShooting);
    }
}
