using UnityEngine;

[System.Serializable]
public class Scene
{

    public GameObject[] scenesGO;
    public GameObject activeScene;

    private void SceneChanger(GameObject newScene)
    {
        newScene.SetActive(true);
        activeScene.SetActive(false);
        activeScene = newScene;
    }
}
