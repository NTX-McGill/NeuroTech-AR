using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Left3Type : MonoBehaviour
{



    public Button zbutton;
    public Button xbutton;
    public Button cbutton;
    public Button vbutton;
  

    ColorBlock cb;
    ColorBlock newcol;


    // Start is called before the first frame update
    void Start()
    {

        cb = zbutton.colors;
        cb.normalColor = Color.white;

        cb.normalColor = Color.white;

        newcol.normalColor = new Color(92, 98, 164, 137);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            zbutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {

            zbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            xbutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.X))
        {

            xbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            cbutton.colors = cb;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {

            cbutton.colors = newcol;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            vbutton.colors = cb;

        }
        if (Input.GetKeyUp(KeyCode.V))
        {

            vbutton.colors = newcol;
        }
        
    }
}
