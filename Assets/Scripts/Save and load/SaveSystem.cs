using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {
    public static void SaveLevel(LevelMenu levelMenu) {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/CurrentLevel.sss";
        using (FileStream fileStream = new FileStream(path, FileMode.Create)) {
            LevelData levelData = new LevelData(levelMenu);

            binaryFormatter.Serialize(fileStream, levelData);
        }
    }

    public static void SaveSpaceship(SpaceshipMenu spaceshipMenu) {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/CurrentSpaceship.sss";
        using (FileStream fileStream = new FileStream(path, FileMode.Create)) {
            SpaceshipData spaceshipData = new SpaceshipData(spaceshipMenu);

            binaryFormatter.Serialize(fileStream, spaceshipData);
        }
    }
}
