using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SituationList : MonoBehaviour
{
    // 시츄에이션 데이터 불러와서 리스트 세팅해준다.
    // 해당 리스트 버튼 아이템들은 다음 상황으로 넘어갈 수 있게 해준다.
    // 마지막에는 컨텐츠 무한 생성중... 버튼을 추가한다. 
    public Transform parent;
    public GameObject listItem;
     
    // Start is called before the first frame update
    void Start()
    {
        SetList();
    }

    XmlManager xmlManager = null;
    public XmlManager GetXmlManager()
    {
        if(xmlManager == null)
        {
            xmlManager = FindObjectOfType<XmlManager>();
        }
        return xmlManager;
    }
    public void SetList()
    {
        List<SituationData> situationDatas = GetXmlManager().situationDatas;

        foreach (SituationData data in situationDatas)
        {
            GameObject item = Instantiate(listItem, parent);
            item.GetComponent<btnSituationSelect>().SetData(data);
        }

        GameObject last_Item = Instantiate(listItem, parent);
        last_Item.GetComponent<btnSituationSelect>().SetData(null);
    }

}
