using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Left2Type : MonoBehaviour
{


   
    public Button abutton;
    public Button sbutton;
    public Button dbutton;
    public Button fbutton;
    public Button gbutton;

    ColorBlock cb;
    ColorBlock newcol;


    // Start is called before the first frame update
    void Start()
    {

        cb = abutton.colors;
        cb.normalColor = Color.white;

        cb.normalColor = Color.white;

        newcol.normalColor = new Color(92, 98, 164, 137);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            abutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            abutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sbutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.S))
        {

            sbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            dbutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            dbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            fbutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.F))
        {

            fbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            gbutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {

            gbutton.colors = newcol;
        }

    }
}
