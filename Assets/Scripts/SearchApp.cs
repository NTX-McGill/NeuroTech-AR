using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchApp : MonoBehaviour
{
    private string[] apps = {"mail","messages","maps","music","weather"};
    public keywordWindowManager windowManager;
    public InputField inputField;
    private List<string> matchedApps = new List<string>();
    private string searchText;

    void Start()
    {
        searchText = inputField.text;
    }

    // Update is called once per frame
    void Update()
    {
        if(!searchText.Equals(inputField.text)){
            searchText=inputField.text;
            matchedApps.Clear();
            for(int i = 0; i<apps.Length;i++){
                if(apps[i].Contains(searchText))
                    matchedApps.Add(apps[i]);
            }
            foreach (string app in matchedApps)
                Debug.Log(app);
        }
        windowManager.populateWindows(matchedApps);
    }
}
