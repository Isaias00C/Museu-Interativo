using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public string targetScene;
    // Start is called before the first frame update
    public void OnClick(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (targetScene == null)
            {
                return;
            }
            else
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(targetScene);
            }
        }

    }
}
