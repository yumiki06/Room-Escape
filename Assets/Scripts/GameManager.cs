using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // パネルの取得
    public GameObject ChairKeyPanel;
    public GameObject ChairDefaultPanel;
    public GameObject StairPanel;

    // ボタンを押すと該当パネルが表示される
    public void OnClickChairTrigger()
    {
        ChairKeyPanel.SetActive(true);
    }
    public void OnClickKeyTrigger()
    {
        ChairDefaultPanel.SetActive(true);
    }
    public void OnClickStairTrigger()
    {
        StairPanel.SetActive(true);
    }



}
