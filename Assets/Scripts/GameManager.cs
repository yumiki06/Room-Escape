using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // パネルの取得
    public GameObject ChairKeyPanel;

    // ボタンを押すと該当パネルを表示する
    public void OnClickChairTrigger()
    {
        ChairKeyPanel.SetActive(true);
    }
    
    // ボタンを押すとパネルを全て非表示にする
    public void OnClickBackTrigger()
    {
        ChairKeyPanel.SetActive(false);
    }


}
