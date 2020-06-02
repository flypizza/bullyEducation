using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleToneSetter : MonoBehaviour
{
    public List<Object> list_Manager_prefabs;
    private void Awake()
    {
        Init();
    }

    public void Init()
    {
        for (int i = 0; i < list_Manager_prefabs.Count; i++)
        {
            Object _object = list_Manager_prefabs[i];
            string objectname = _object.name + "(Clone)";
            if (GameObject.Find(objectname) == null)
            {
                Instantiate(_object, transform.parent);
            }
        }
    }

}
