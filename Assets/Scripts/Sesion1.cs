using UnityEngine;

public class Sesion1 : MonoBehaviour
{
    
    void Start()
    {



        Debug.Log("iniciando el curso.");

        int numero1 = 20394;
        int numero2 = 103931; 
        
        int suma = numero1 + numero2;

        int numero3 = 130;
        int numero4 = 340; 
         
        int multiplicacion = numero3 * numero4;

        float numero5 = 10.5f;
        float numero6 = 4.0f; 

        float division = numero5 / numero6;

        Debug.Log(suma);
        Debug.Log(multiplicacion); 
        Debug.Log(division);

        float variable1 = 2f;
        float variable2 = 3f; 

        float resultadoDeVariables = variable1 * variable2;

        float metros = 2500f;
        float factor = 1609f;

        float millas = metros / factor;

        Debug.Log(millas);
        Debug.Log(resultadoDeVariables);

        

    }

    
    void Update()
    {
        
    }
}
