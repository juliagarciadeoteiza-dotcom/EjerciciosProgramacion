using UnityEngine;

public class Sesion2 : MonoBehaviour
{
    
    void Start()
    {

        int FlappyPosY = 800;

        int upperLimitY = 700; 
        int lowerLimitY = 0; 


        if (FlappyPosY > upperLimitY || FlappyPosY < lowerLimitY)
        {

            Debug.Log("esta muerto."); 

        }




        int indiceDia = 3; 

            if indiceDia = 1
            {
            Debug.Log("Lunes"); 

        }
        if indiceDia == 2
            {
            Debug.Log("Martes");

        }
        if indiceDia == 3
            {
            Debug.Log("Miercoles");

        }
        if indiceDia == 4
            {
            Debug.Log("Jueves");

        }
        if indiceDia == 5
            {
            Debug.Log("Viernes");

        }

        if indiceDia == 6
            {
            Debug.Log("Sabado");

        }

        if indiceDia == 7
            {
            Debug.Log("Domingo");

        }




        int coordenadaX = 3;
        int coordenadaY = 6; 


        if (coordenadaX > 0 && coordenadaY > 0)
        {

            Debug.Log("Cuadrante uno")

        }

        if (coordenadaX > 0 && coordenadaY < 0)
        {

            Debug.Log("Cuadrante dos")

        }

        if (coordenadaX < 0 && coordenadaY < 0)
        {

            Debug.Log("Cuadrante tres")

        }

        if (coordenadaX < 0 && coordenadaY > 0)
        {

            Debug.Log("Cuadrante cuatro")

        }



        int piedra = 1; 
        int papel = 2;
        int tijeras = 3;


        if (piedra == 1 && papel == 2)
        {
            Debug.Log("gana papel"); 
        }

        if (piedra == 1 && tijeras == 2)
        {
            Debug.Log("gana piedra");
        }

        if (piedra == 1 && piedra == 2)
        {
            Debug.Log("empate");
        }

        if (papel == 1 && papel == 2)
        {
            Debug.Log("empate");
        }

        if (papel == 1 && tijeras == 2)
        {
            Debug.Log("gana tijeras");
        }

        if (papel == 1 && piedra == 2)
        {
            Debug.Log("gana papel");
        }

        if (tijeras == 1 && papel == 2)
        {
            Debug.Log("gana tijeras");
        }

        if (tijeras == 1 && tijeras == 2)
        {
            Debug.Log("empate");
        }

        if (tijeras == 1 && piedra == 2)
        {
            Debug.Log("gana piedra");
        }







        int dados = 7; 

        if (dados > 4)
        {


            Debug.Log("impacta")


           if (dados > 5)
            {

                Debug.Log("genera tirada de defensa")

            }
           else if 
        }

        if (dados < 4)
        {

            Debug.Log("no impacta")
        }











    }





    void Update()
    {
        
    }
}
