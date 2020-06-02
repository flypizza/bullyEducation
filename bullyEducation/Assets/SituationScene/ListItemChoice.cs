using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ListItemChoice : MonoBehaviour
{
    public Button btn;
    public Text txt_choice;

    private void Awake()
    {
        btn.onClick.AddListener(OnClick_Choice);
    }

    ChoiceData choiceData = null;
    public void SetData(ChoiceData data)
    {
        choiceData = data;
        txt_choice.text = choiceData.choice;
    }
    
    public void OnClick_Choice()
    {
        FindObjectOfType<SaveHandler>().CUR_SELECT_CHOICE_DATA = choiceData;
        SceneManager.LoadScene("ResultScene");
    }

}
