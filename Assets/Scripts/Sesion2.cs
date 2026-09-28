using UnityEngine;

public class Sesion2 : MonoBehaviour
{
    
    void Start()
    {


        int fuerza = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;
        int con = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;
        int des = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;
        int apariencia = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;
        int poder = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;
        int suerte = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;


        int tamaño = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;
        int inteligencia = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;
        int educacion = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5;



        int edad = Random.Range (15,90); 


        if 15 <= edad && edad <= 19;

        {

            Debug.Log("Modificacion")

            fuerza -= 5; 
            tamaño -= 5;
            educacion -= 5;


        }

        //rerollea suerte

        int sureReroll = (Random.Range(1, 7) + (Random.Range(1, 7) + (Random.Range(1, 7)) * 5; 
        if (sureReroll > suerte)
        {
            suerte = sureReroll;
        }
        {
            else if (20<= edad && edad <= 39)
            {
                //MEJORA DE EDUCACION

                int Und100 = Random.Range(1, 101);

                if (Und100 > educacion)
                {
                    Debug.Log("Has estudiado");
                    educacion = educacion + Random.Range(1, 11);
                }
            }
        }

    }

    
    void Update()
    {
        
    }
}
