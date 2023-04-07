using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCloud : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] GameObject particle;
    private void Start()
    {
        playerController.OnClickedCloud += PlayerController_OnClickedCloud;
    }

    private void PlayerController_OnClickedCloud(object sender, System.EventArgs e)
    {
        Debug.Log("Create Particle");
    }

    private void Update()
    {
        DestroySpawnedObject(this.gameObject);
    }
    void DestroySpawnedObject(GameObject obj)
    {
        if (obj.transform.position.x > 5 || obj.transform.position.x < -5)
        {
            Destroy(obj);
        }
    }
}
