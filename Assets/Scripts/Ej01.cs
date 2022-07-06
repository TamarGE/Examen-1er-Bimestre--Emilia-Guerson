using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public float montoInicialPesos;
    public string convertirEnMoneda;
    // Start is called before the first frame update
    void Start()
    {
       
        if (montoInicialPesos < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else
        {
            double montoConvertidoExtranjero;
            string nombreMonedaElegida;
            switch (convertirEnMoneda)
            {
                case "D":
                    montoConvertidoExtranjero = montoInicialPesos * 0.00888;
                    nombreMonedaElegida = "dólares";
                    Debug.Log(montoInicialPesos+" pesos argentinos equivalen a " +montoConvertidoExtranjero+ " " +nombreMonedaElegida);
                    break;
                case "R":
                    montoConvertidoExtranjero = montoInicialPesos * 0.04190;
                    nombreMonedaElegida = "reales";
                    Debug.Log(montoInicialPesos + " pesos argentinos equivalen a " + montoConvertidoExtranjero + " " + nombreMonedaElegida);
                    break;
                case "E":
                    montoConvertidoExtranjero = montoInicialPesos * 0.00816;
                    nombreMonedaElegida = "euros";
                    Debug.Log(montoInicialPesos + " pesos argentinos equivalen a " + montoConvertidoExtranjero + " " + nombreMonedaElegida);
                    break;
                default:
                    Debug.Log("Opción de moneda extranjera no válida");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // :)
    }
}
