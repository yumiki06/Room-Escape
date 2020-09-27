using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // パネルの取得
    public GameObject ChairKeyPanel;
    public GameObject ChairDefaultPanel;

    // ボタンを押すと該当パネルを表示する
    public void OnClickChairTrigger()
    {
        ChairKeyPanel.SetActive(true);
    }
    public void OnClickKeyTrigger()
    {
        ChairDefaultPanel.SetActive(true);
    }


}
