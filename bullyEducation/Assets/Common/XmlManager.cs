using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System;

[Serializable]
public class SituationData
{
    public int no;
    public string key;
    public string situation;
}

[Serializable]
public class ChoiceData
{
    public string situation_key;
    public string choice;
    public string result;
    public int suc;
}

public class XmlManager : MonoBehaviour
{
    public List<SituationData> situationDatas;
    public List<ChoiceData> choiceDatas;

    private void Awake()
    {
            DontDestroyOnLoad(this);
            InitData();
    }
    public void InitData()
    {
        situationDatas = Load_SituationXML();
        choiceDatas = Load_ChoiceXML();
    }
    public List<SituationData> Load_SituationXML()
    {
        List<SituationData> return_data = new List<SituationData>();

        TextAsset txtAsset = (TextAsset)Resources.Load("xml/situation");
        XmlDocument xmlDoc = new XmlDocument();
        Debug.Log(txtAsset.text);
        xmlDoc.LoadXml(txtAsset.text);

        // 전체 아이템 가져오기 예제.
        XmlNodeList all_nodes = xmlDoc.SelectNodes("Root/text");
        foreach (XmlNode node in all_nodes)
        {
            // 수량이 많으면 반복문 사용.
            SituationData mower = new SituationData
            {
                no = int.Parse(node.SelectSingleNode("no").InnerText),
                key = node.SelectSingleNode("key").InnerText,
                situation = node.SelectSingleNode("situation").InnerText
            };

            return_data.Add(mower);
        }

        return return_data;
    }

    public List<ChoiceData> Load_ChoiceXML()
    {
        List<ChoiceData> return_data = new List<ChoiceData>();

        TextAsset txtAsset = (TextAsset)Resources.Load("xml/choice");
        XmlDocument xmlDoc = new XmlDocument();
        Debug.Log(txtAsset.text);
        xmlDoc.LoadXml(txtAsset.text);

        // 전체 아이템 가져오기 예제.
        XmlNodeList all_nodes = xmlDoc.SelectNodes("Root/text");
        foreach (XmlNode node in all_nodes)
        {
            // 수량이 많으면 반복문 사용.
            ChoiceData choiceData = new ChoiceData
            {
                situation_key = node.SelectSingleNode("situation").InnerText,
                choice = node.SelectSingleNode("choice").InnerText,
                result = node.SelectSingleNode("result").InnerText,
                suc = Int32.Parse(node.SelectSingleNode("suc").InnerText)
            };

            return_data.Add(choiceData);
        }

        return return_data;
    }
}
