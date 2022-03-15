using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuartel : MonoBehaviour
{

    [SerializeField] private Edificios edi;
    [SerializeField] private esquleto invoc1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        edi.edificio = 1;
    }

    public void reclutar1() 
    {
        
        Instantiate(invoc1);
        print("reclutamiento finalizado");
        edi.hayedificio = true;
    }
}
