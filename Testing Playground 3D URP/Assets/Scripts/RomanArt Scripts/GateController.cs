using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateController : MonoBehaviour
{
    GateSettings gateSettings;

    bool switchScene, switched;

    Scene nextScene, fromScene;

    private void Start()
    {
        gateSettings = transform.parent.GetComponentInParent<GateSettings>();

        switchScene = false;
        switched = false;

        nextScene = SceneManager.GetSceneByName(gateSettings.toScene);
        fromScene = SceneManager.GetActiveScene();

        // Debug
        Debug.Log(fromScene.name);
    }

    private void Update()
    {
        if (nextScene.isLoaded & !switched)
            switchScene = true;

        if (switchScene)
        {
            switcScene();
            
            GameObject[] gates = GameObject.FindGameObjectsWithTag("Gate");
            foreach (GameObject gate in gates)
                if (gate.GetComponent<GateSettings>().GateName == gateSettings.toGate)
                    Debug.Log("toGate was found!");

            switchScene = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Load the toScene
            SceneManager.LoadScene(gateSettings.toScene, LoadSceneMode.Additive);

            // Everything else occurs after scene load...
        }
    }



    private void switcScene()
    {
        SceneManager.SetActiveScene(nextScene);
        //SceneManager.UnloadSceneAsync(fromScene);
    }

}   
