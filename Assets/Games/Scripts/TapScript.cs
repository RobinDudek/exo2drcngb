using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{


    public Material[] materials;
    private Renderer rend;
    private int cpt;

    public GameObject sphere;
    public GameObject cube;
    public GameObject cylindre;
    public GameObject secondplan;
    public GameObject canvas;

    void Start()
    {
        /*sphere = GameObject.FindWithTag("SpherePremierPlan"); 
        cube = GameObject.FindWithTag("CubePremierPlan");
        cylindre = GameObject.FindWithTag("CylindrePremierPlan");
        secondplan = GameObject.FindWithTag("SecondPlan");*/
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {

            Debug.Log("Hello j'ai cliqué");

            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if( raycastHit.collider.transform.parent.CompareTag("SecondPlan"))
                {
                    if (raycastHit.collider.CompareTag("Sphere"))
                    {
                        Debug.Log("Sphere clicked");
                        sphere.SetActive(true);
                        cube.SetActive(false);
                        cylindre.SetActive(false);
                    }
                    if (raycastHit.collider.CompareTag("Cube"))
                    {
                        Debug.Log("Cube clicked");
                        sphere.SetActive(false);
                        cube.SetActive(true);
                        cylindre.SetActive(false);
                    }
                    if (raycastHit.collider.CompareTag("Cylindre"))
                    {
                        Debug.Log("Cylindre clicked");
                        sphere.SetActive(false);
                        cube.SetActive(false);
                        cylindre.SetActive(true);
                    }

                    secondplan.SetActive(false);
                    canvas.SetActive(true);
                }
                if (raycastHit.collider.transform.parent.CompareTag("PremierPlan"))
                {
                    rend = raycastHit.collider.GetComponent<Renderer>();
                    rend.enabled = true;
                    onTap();

                    /*if (raycastHit.collider.CompareTag("SpherePremierPlan"))
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
                    }*/

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
