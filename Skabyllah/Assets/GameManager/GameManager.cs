using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI saveText;
    private string inputText = "TuMaCane";
    public string sTxt;

    //create the file path to the txt document are we using in

    private const string DIR_RES = "/Resources";
    private const string FILE_INFOSAVE = DIR_RES + "/infoSave.txt";
    private string FILE_PATH_INFO;
    // Start is called before the first frame update
    void Start()
    {
        //declare the file path
        FILE_PATH_INFO = Application.dataPath + FILE_INFOSAVE;
        saveText.text = inputText;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SaveText(string text)
    {
        sTxt = text;
        string fileContents = File.ReadAllText(FILE_PATH_INFO);
        fileContents += sTxt + "\n";
        File.WriteAllText(FILE_PATH_INFO, fileContents);
    }

    public void LoadText()
    {
        string filecontents = File.ReadAllText(FILE_PATH_INFO);
        saveText.text = filecontents;
    }
}
