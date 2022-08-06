using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LoadingSpaceship : MonoBehaviour {
    [SerializeField] private GameObject raiderSpaceship;
    [SerializeField] private GameObject tupolevSpaceship;

    void Start() {
        if (GetSpaceshipName() == "Raider") {
            raiderSpaceship.SetActive(true);
            tupolevSpaceship.SetActive(false);
        }
        else if (GetSpaceshipName() == "Tupolev") {
            raiderSpaceship.SetActive(false);
            tupolevSpaceship.SetActive(true);
        }
        else {
            Application.Quit();
        }
    }

    private static string GetSpaceshipName() {
        string path = Application.persistentDataPath + "/CurrentSpaceship.sss";
        if (File.Exists(path)) {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(path, FileMode.Open)) {
                SpaceshipData spaceshipData = binaryFormatter.Deserialize(fileStream) as SpaceshipData;

                return spaceshipData.SpaceshipName;
            }
        }
        else {
            return null;
        }
    }
}
