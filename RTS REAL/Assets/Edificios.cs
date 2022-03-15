using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Edificios : MonoBehaviour
{


    public int edificio;
    public bool hayedificio;
    [SerializeField] private TextMeshProUGUI tipoedificio;
    [SerializeField] private GameObject interfaz;
    [SerializeField] private GameObject interfazcuartel;
    [SerializeField] private GameObject boton1;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

          

            

            if (hit.collider.gameObject.layer == 6)
            {
                hayedificio = true;
                print("estoy tocando");
            }
            
            
           

            print(hit.collider.gameObject);




        }


        if (Input.GetMouseButtonDown(1))
        {
            // Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);





            hayedificio = false;




        }


        if (hayedificio==false) 
        {
            interfaz.SetActive(false);
        }


        if(hayedificio==true) 
        {
            interfaz.SetActive(true);
        }



        if(edificio == 0) 
        {
            interfazcuartel.SetActive(false);
            tipoedificio.text = "foro";
            
        }


        if (edificio == 1)
        {
            
            interfazcuartel.SetActive(true);
            tipoedificio.text= "cuartel";
        }


        else if (edificio == 2)
        {
            interfazcuartel.SetActive(false);
            tipoedificio.text = "herreria";
        }
        
    }
}
