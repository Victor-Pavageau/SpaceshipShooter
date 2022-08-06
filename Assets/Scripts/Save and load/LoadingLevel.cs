using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LoadingLevel : MonoBehaviour {
    [SerializeField] private GameObject moonLevel;
    [SerializeField] private GameObject marsLevel;

    void Start() {
        if(GetLevelName() == "MoonLevel") {
            moonLevel.SetActive(true);
            marsLevel.SetActive(false);
        }
        else if(GetLevelName() == "MarsLevel") {
            moonLevel.SetActive(false);
            marsLevel.SetActive(true);
        }
        else {
            Application.Quit();
        }
    }

    private static string GetLevelName() {
        string path = Application.persistentDataPath + "/CurrentLevel.sss";
        if(File.Exists(path)) {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(path, FileMode.Open)) {
                LevelData levelData = binaryFormatter.Deserialize(fileStream) as LevelData;

                return levelData.LevelName;
            }
        }
        else {
            return null;
        }
    }
}
