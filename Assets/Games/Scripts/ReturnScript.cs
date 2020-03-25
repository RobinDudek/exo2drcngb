using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{

    public GameObject sphere;
    public GameObject cube;
    public GameObject cylindre;
    public GameObject secondplan;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnButton()
    {
        sphere.SetActive(false);
        cube.SetActive(false);
        cylindre.SetActive(false);
        secondplan.SetActive(true);
        canvas.SetActive(false);
    }
}
