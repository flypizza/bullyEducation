using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btnSituationSelect : MonoBehaviour
{
    Button btn;
    Text txt_btn;

    SituationData curData = null;

    private void Awake()
    {
        txt_btn = GetComponentInChildren<Text>();
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClickButton);
    }
    public void SetData(SituationData data)
    {
        curData = data;
        if (data == null)
        {
            txt_btn.text = "Coming\nSoon";
            txt_btn.fontSize = 45;
            btn.enabled = false;
            GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.3f);
        }
        else
        {
            // lock check
            txt_btn.text = "상황" + data.no;
            btn.enabled = true;
        }
    }

    public void OnClickButton()
    {
        if(curData != null)
        {
            FindObjectOfType<SaveHandler>().CUR_SITU = curData;
            SceneManager.LoadScene("SituationScene");
        }
    }
}
