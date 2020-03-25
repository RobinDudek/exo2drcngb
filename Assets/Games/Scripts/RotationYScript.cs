using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationYScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.parent.CompareTag("PremierPlan"))
        {
            //si il appuie avec plusieurs doigts sur l'écran, prends en compte le premier
            if (Input.touchCount >= 1)
            {
                // GET TOUCH 0
                Touch touch0 = Input.GetTouch(0);

                // APPLY ROTATION
                if (touch0.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, touch0.deltaPosition.x, 0f);
                }
            }
        } else
        {
            transform.Rotate(0, 0.15f, 0, Space.Self);
        }
    }
}
