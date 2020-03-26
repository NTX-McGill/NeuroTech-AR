using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keywordWindowManager : MonoBehaviour
{
    public GameObject windowA;
    public GameObject windowF;
    public GameObject windowJ;
    public GameObject windowEnter;
    private GameObject[] windows= new GameObject[4];
    private Color disappear;
    private Color appear;
    // Start is called before the first frame update
    void Start()
    {
        appear = new Color(1.0f,1.0f,1.0f,1.0f);
        disappear = new Color(1.0f,1.0f,1.0f,0.0f);
        windows[0] = windowA;
        windows[1] = windowF;
        windows[2] = windowJ;
        windows[3] = windowEnter;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void populateWindows(List<string> values){
        for(int i=0; i<4; i++){
            if(i<values.Count){
                windows[i].GetComponent<MeshRenderer>().materials[0].color = Color.Lerp(windows[i].GetComponent<MeshRenderer>().materials[0].color, appear, 1f * Time.deltaTime);
                windows[i].GetComponent<MeshRenderer>().materials[1].color = Color.Lerp(windows[i].GetComponent<MeshRenderer>().materials[1].color, appear, 1f * Time.deltaTime);
                windows[i].transform.GetChild(0).GetComponent<TextMesh>().text = values[i];
            }
            else{
                windows[i].GetComponent<MeshRenderer>().materials[0].color = Color.Lerp(windows[i].GetComponent<MeshRenderer>().materials[0].color, disappear, 10f * Time.deltaTime);
                windows[i].GetComponent<MeshRenderer>().materials[1].color = Color.Lerp(windows[i].GetComponent<MeshRenderer>().materials[1].color, disappear, 10f * Time.deltaTime);
                windows[i].transform.GetChild(0).GetComponent<TextMesh>().text = "";
            }
       }
    }

}
