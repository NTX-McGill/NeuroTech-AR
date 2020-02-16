using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type : MonoBehaviour
{


    public GameObject rightcube;
    public Button qbutton;
    public Button wbutton;
    public Button ebutton;
    public Button rbutton;
    public Button tbutton;

    ColorBlock cb;
    ColorBlock newcol;


    // Start is called before the first frame update
    void Start()
    {

        cb = qbutton.colors;
        cb.normalColor = Color.white;

        cb.normalColor = Color.white;

        newcol.normalColor = new Color(92, 98, 164, 137);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            qbutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {

            qbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            wbutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.W))
        {

            wbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ebutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {

            ebutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            rbutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.R))
        {

            rbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            tbutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.T))
        {

            tbutton.colors = newcol;
        }

    }
}
