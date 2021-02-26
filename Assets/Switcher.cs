using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject g1;
    public GameObject g2;
    void Start()
    {
        g1.SetActive(false);
    }

    public void  switchem()
    {
        if (g1.activeSelf == true)
        {
            g2.SetActive(true);
            g1.SetActive(false);
        }
        else if (g2.activeSelf == true)
        {
            g1.SetActive(true);
            g2.SetActive(false);
        }
        else
        {
            print("Something aint right");
        }
    }
}
