using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula1Puzzle : MonoBehaviour
{
    public bool completada;
    public BancoController banco1;
    public BancoController banco2;
    public BancoController banco3;
    public BancoController banco4;
    public BancoController banco5;
    public BancoController banco6;
    public BancoController banco7;
    public BancoController banco8;
    public BancoController banco9;
    public BancoController banco10;
    public BancoController banco11;
    public BancoController banco12;
    public BancoController banco13;
    public BancoController banco14;
    public BancoController banco15;
    public BancoController banco16;
    
    void Start()
    {
        completada = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (banco4.volteado && banco5.volteado && banco11.volteado && banco13.volteado && 
            !banco1.volteado && !banco2.volteado && !banco3.volteado && !banco6.volteado && !banco7.volteado && !banco8.volteado && !banco9.volteado && 
            !banco10.volteado && !banco12.volteado && !banco14.volteado && !banco15.volteado && !banco16.volteado)
        {
            completada = true;
        }
    }
    
}
