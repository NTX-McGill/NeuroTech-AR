using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collapse : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dock;
    public GameObject[] views;
    public GameObject[] text;
    public InputField inputField;
    public float collapseTime = 1.0f;
    private bool collapsing;
    private string appName;

    void Start()
    {
       collapsing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") || collapsing){
            if(!collapsing){
                inputField.ActivateInputField();
                inputField.Select();
                inputField.placeholder.GetComponent<Text>().text = "Search...";
            }
            collapsing = true;
            if(dock.transform.localScale.z>235.0f-150.0f)
                dock.transform.localScale -= new Vector3(0.0f,0.0f,150.0f/collapseTime*Time.deltaTime);
            foreach (GameObject v in views) {
                if(v.transform.localScale.z>0.1)
                    v.transform.localScale -= new Vector3(0.0f,0.0f,176.0f/collapseTime*Time.deltaTime);
                else{
                    v.SetActive(false);
//                  v.GetComponent<Renderer>().enabled = false;
//                  foreach (Transform child in v.transform)
//                      child.gameObject.SetActive(false);
                }
            }
            foreach (GameObject t in text) {
                if(t.transform.position.y>5.4-1.5)
                    t.transform.position -= new Vector3(0.0f,1.5f/collapseTime*Time.deltaTime,0.0f);
                else
                    t.GetComponent<TextMesh>().color = Color.black;
            }
       }
       else if (Input.GetKeyDown("a")){
            collapsing = true;
            Application.LoadLevelAdditive("mail");
       }
    }
}
