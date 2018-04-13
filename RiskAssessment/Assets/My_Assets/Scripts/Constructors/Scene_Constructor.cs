using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Constructor : MonoBehaviour
{
    public Scene scene;
    
    private void Awake()
    {
        if (scene.scenesGO != null)
            scene.activeScene = scene.scenesGO[0];
        else
            Debug.Log("ERROR: Scene array NULL.");
        Debug.Log("Active Scene: " + scene.activeScene.name);
    }

    private void Start()
    {

    }

}
