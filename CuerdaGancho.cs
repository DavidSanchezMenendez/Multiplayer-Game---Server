using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuerdaGancho : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Camera cam;
  
    bool dejargancho = false;
    public Transform quitarGancho;
    public LineRenderer line;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit raycastHit))//Golpea a cualqueiro cosa
            {
                if (Input.GetKey(KeyCode.E))
                {


                    if (raycastHit.transform.CompareTag("Mapa") && !dejargancho)
                    {
                       
                        line.SetPosition(0, quitarGancho.position);
                        line.SetPosition(1, raycastHit.point);
                       

                        
                    }


                }
                else
                {
                    line.SetPosition(0, quitarGancho.position);
                    line.SetPosition(1, quitarGancho.position);
                }

               

            }
        }
        else
        {
            dejargancho = false;
            line.SetPosition(0, quitarGancho.position);
            line.SetPosition(1, quitarGancho.position);


        }
    }
        
}
