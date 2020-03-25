using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{
    // Start is called before the first frame update

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
