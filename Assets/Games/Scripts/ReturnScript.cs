using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    GameObject sphere;
    GameObject cube;
    GameObject cylindre;
    GameObject secondplan;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("SpherePremierPlan");
        cube = GameObject.FindGameObjectWithTag("CubePremierPlan");
        cylindre = GameObject.FindGameObjectWithTag("CylindrePremierPlan");
        secondplan = GameObject.FindGameObjectWithTag("SecondPlan");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void returnButton()
    {
        sphere.SetActive(false);
        cube.SetActive(false);
        cylindre.SetActive(false);
        secondplan.SetActive(true);
    }
}
