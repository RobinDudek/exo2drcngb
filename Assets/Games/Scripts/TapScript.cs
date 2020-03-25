using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if( raycastHit.collider.transform.parent.CompareTag("SecondPlan"))
                {
                    if (raycastHit.collider.CompareTag("Sphere"))
                    {
                        Debug.Log("Sphere clicked");
                    }
                    if (raycastHit.collider.CompareTag("Cube"))
                    {
                        Debug.Log("Cube clicked");
                    }
                    if (raycastHit.collider.CompareTag("Cylindre"))
                    {
                        Debug.Log("Cylindre clicked");
                    }
                }
                if (raycastHit.collider.transform.parent.CompareTag("PremierPlan"))
                {
                    if (raycastHit.collider.CompareTag("SpherePremierPlan"))
                    {
                        Debug.Log("Sphere clicked");
                    }
                    if (raycastHit.collider.CompareTag("CubePremierPlan"))
                    {
                        Debug.Log("Cube clicked");
                    }
                    if (raycastHit.collider.CompareTag("CylindrePremierPlan"))
                    {
                        Debug.Log("Cylindre clicked");
                    }
                }
            }
        }
    }
}
