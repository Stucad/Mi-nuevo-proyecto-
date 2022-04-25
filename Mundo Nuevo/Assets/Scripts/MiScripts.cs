using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScripts : MonoBehaviour
{
    public string MensajeBienvenida;
    public string MiNombre;
    public string Nombreamigo;
    public int edad_mia;
    public int edad_amigo;


   



    // Start is called before the first frame update
    void Start()
    {
        int Total;
        Total = edad_amigo + edad_mia;
            
        Debug.Log("Nos Llamamos" + MiNombre + (" ") + "Y" + Nombreamigo);
        Debug.Log("Tenemos" + edad_mia + "," + edad_amigo + (" ") + "Años" );
        Debug.Log("La suma de nuestras edades es" + (" ") + Total);





        




    }

    // Update is called once per frame
    void Update()
    {

        
    }
    

}
