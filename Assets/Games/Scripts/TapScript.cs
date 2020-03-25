using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{


    public Material[] materials;
    private Renderer rend;
    private int cpt;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[cpt];
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

    void onTap()
    {
        cpt++;
        if (cpt == materials.Length)
        {
            cpt = 0;
        }
        rend.sharedMaterial = materials[cpt];
    }
}
