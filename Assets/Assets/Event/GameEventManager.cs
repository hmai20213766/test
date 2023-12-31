using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager : MonoBehaviour
{
    public static GameEventManager instance{ get;private set;}

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one GameEventManager working");
        }
        instance=this;
    }
}
