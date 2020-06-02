using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHandler : MonoBehaviour
{
    string curSitu_key = "MONEY_STEAL";
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public string CUR_SITU_KEY 
    {
        get
        {
            return curSitu_key;
        }
        set
        {
            curSitu_key = value;
        }
    }
    ChoiceData curSelect_ChoiceData = null;
    public ChoiceData CUR_SELECT_CHOICE_DATA
    {
        get
        {
            return curSelect_ChoiceData;
        }
        set
        {
            curSelect_ChoiceData = value;
        }
    }

}
