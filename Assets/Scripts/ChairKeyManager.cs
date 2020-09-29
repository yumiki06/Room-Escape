using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairKeyManager : MonoBehaviour
{
    [SerializeField] GameObject RoomKeyPanel;
    [SerializeField] GameObject AlertText;
    [SerializeField] ItemBoxManager ItemBoxManager;

    void Start()
    {
        RoomKeySetActive(false);
    }

    void RoomKeySetActive(bool isShow)
    {
        RoomKeyPanel.SetActive(isShow);
        AlertText.SetActive(isShow);
    }

    //鍵をクリックすると
    //1.鍵の画像を表示する
    //2.テキストを表示する
    public void OnClickTrigger()
    {
        RoomKeySetActive(true);
        ItemBoxManager.SetItem(ITEM.ROOM_KEY);
    }

    //鍵の画像をクリックすると非表示に切り替える
    public void OnClickImage()
    {
        RoomKeySetActive(false);
    }
}