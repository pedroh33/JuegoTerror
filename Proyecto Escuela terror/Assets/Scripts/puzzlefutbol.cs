using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string[] golesTotales = new string[4]; // Casillero donde van los 5 goles metidos en el partido
    bool puzzleResuelto;

    // Es una secuencia que comprueba un orden, que cuando falla tiene que reiniciarse
    // secuencia = orden
    void Start()
    {

    }


    void Update()
    {
        puzzleResuelto = false; // como lo paso a true ? -Resolviendo secuencia  
    }
    
    void IniciaPartido(bool revistaOle)  //funcion para iniciar Puzzle con revista Ole
    {
                          //Tengo pensado hacer for que siga la array haciendo que se cumpla un if que vaya anotando puntos
                          //hasta llegar a que el bool del puzle resuelto sea TRUE
                          //
                          
    }
}
