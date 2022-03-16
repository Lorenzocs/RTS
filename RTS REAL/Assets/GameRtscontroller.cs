using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.AI;

public class GameRtscontroller : MonoBehaviour
{

    [SerializeField] private Transform selectarea;
    private Vector3 startposition;
    private List<unitRTS> selectedunitRTSList;
    // Start is called before the first frame update



    private void Awake()
    {
        selectedunitRTSList = new List<unitRTS>();
        selectarea.gameObject.SetActive(false);
    }



    void Start()

    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            selectarea.gameObject.SetActive(true);
            startposition = UtilsClass.GetMouseWorldPosition();
        }

        if(Input.GetMouseButton(0)) 
        {
            Vector3 currentmouseposition = UtilsClass.GetMouseWorldPosition();
            Vector3 lowerleft = new Vector3
                (Mathf.Min(startposition.x, currentmouseposition.x),
               Mathf.Min(startposition.y, currentmouseposition.y)
               );

            Vector3 upperrigth = new Vector3(
                Mathf.Max(startposition.x, currentmouseposition.x),
                Mathf.Max(startposition.y, currentmouseposition.y)
                );
            selectarea.position = lowerleft;
            selectarea.localScale = upperrigth - lowerleft;
        }



        if (Input.GetMouseButtonUp(0)) 
        {
            selectarea.gameObject.SetActive(false);
            Debug.Log(UtilsClass.GetMouseWorldPosition() + " " + startposition);
            Collider2D[] collider2DsArray= Physics2D.OverlapAreaAll(startposition, UtilsClass.GetMouseWorldPosition());


            selectedunitRTSList.Clear();
            foreach(Collider2D collider2D in collider2DsArray) 
            {
                unitRTS unitrts = collider2D.GetComponent<unitRTS>();
                if(unitrts!=null) 
                {
                    selectedunitRTSList.Add(unitrts);
                }

            }

            Debug.Log(selectedunitRTSList.Count);

        }

        if (Input.GetMouseButtonDown(1))
        {


            Vector3 moveposition = UtilsClass.GetMouseWorldPosition();

            List<Vector3> targetpositionlist = new List<Vector3>
            {
                moveposition + new Vector3(0,0),
                moveposition + new Vector3(1,0),
                moveposition + new Vector3(0,1),
                moveposition + new Vector3(1,1),
                
               
            };
            int targetpositionlistindex = 0;
            foreach (unitRTS unitRTS in selectedunitRTSList)
            {
                unitRTS.agent.SetDestination(targetpositionlist[targetpositionlistindex]);
                targetpositionlistindex = targetpositionlistindex + 1 % targetpositionlist.Count;
            }
        }

    }
}
