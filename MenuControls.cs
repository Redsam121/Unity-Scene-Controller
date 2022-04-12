using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    private Scenecontrols sceneController;    // Reference to the SceneController to actually do the loading and unloading of scenes.

    // Start is called before the first frame update
    void Start()
    {
        sceneController = FindObjectOfType<Scenecontrols>();
    }
    public void superMarbleDroppers()
    {
        sceneController.switchScene("SuperMarbleDroppers");
    }
    public void wireLoop()
    {
        sceneController.switchScene("WireLoop");
    }
    public void eggNbowl()
    {
        sceneController.switchScene("Egg_in_Bowl");
    }
}
