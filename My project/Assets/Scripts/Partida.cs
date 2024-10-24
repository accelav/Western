using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Partida : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaBegin;
    [SerializeField]
    GameObject pantallaFinal;
    [SerializeField]
    TextMeshProUGUI tiempoAtras;
    [SerializeField]
    TextMeshProUGUI textoSaldo;
    [SerializeField]
    TextMeshProUGUI saldoFinal;




    public float contador = 60f;
    public int saldo = 000;

    bool estaEmpezada = false;


    void Start()
    {
        textoSaldo.text = saldo.ToString("000");
        tiempoAtras.text = contador.ToString();
        pantallaFinal.SetActive(false);

        

        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (estaEmpezada == true)
        {
            
            contador -= Time.deltaTime;


            if (contador <= 0f)
            {
                contador = 0f;
                pantallaFinal.SetActive(true);
                saldoFinal.text = saldo.ToString();
            }


        }
        tiempoAtras.text = contador.ToString("00");
        textoSaldo.text = saldo.ToString("000");



    }

    public void EmpezarPartida()
    {
        contador = 60f;
        estaEmpezada = true;
        pantallaBegin.SetActive(false);


    }

    public void SumarBadGuy()
    {
        
        saldo += 500;
    }

    public void SumarBadGuyDos()
    {

        saldo += 750;
    }

    public void RestarGoodGuy()
    {

        saldo -= 50;
    }

    public void RestarLady()
    {

        saldo -= 80;
    }

    public void RestarSheriff()
    {

        saldo -= 100;
    }

    public void Replay()
    {
        pantallaFinal.SetActive(false);
        saldo = 000;
        contador = 60f;
        estaEmpezada = false;
        pantallaBegin.SetActive(true);
    }

}
