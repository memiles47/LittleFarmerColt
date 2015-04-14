using UnityEngine;
using System.Collections;

public class LoadSceenOnClick : MonoBehaviour
{
    public void LoadScene(int scene)
    {
        Application.LoadLevel(scene);
    }
}
