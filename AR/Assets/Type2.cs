using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type2 : MonoBehaviour
{

    public GameObject rightcube;
    public Button ybutton;
    public Button ubutton;
    public Button ibutton;
    public Button obutton;
    public Button pbutton;

    ColorBlock cb;
    ColorBlock newcol;


    // Start is called before the first frame update
    void Start()
    {

        cb = ybutton.colors;
        cb.normalColor = Color.white;

        //newcol = ybutton.colors;
        newcol.normalColor = new Color(164, 92, 95, 137);
       



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ybutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {

            ybutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            ubutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.U))
        {

            ubutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            ibutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {

            ibutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            obutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.O))
        {

            obutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            pbutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {

            pbutton.colors = newcol;
        }

    }
}
