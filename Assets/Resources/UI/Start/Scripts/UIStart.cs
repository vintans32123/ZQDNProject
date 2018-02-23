﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIStart : MonoBehaviour
{

    void Start()
    {
        Transform RankPK = transform.Find("Body/RankPK");
        if (RankPK != null)
        {
            UIEventListener.Get(RankPK.gameObject).onClick += (go) => SceneManager.LoadScene("RankPK");
        }

        Transform Rank = transform.Find("Body/Rank");
        if (Rank != null)
        {
            UIEventListener.Get(Rank.gameObject).onClick += OnClickRank;
        }

        Transform Shop = transform.Find("Body/Shop");
        if (Shop != null)
        {
            UIEventListener.Get(Shop.gameObject).onClick += (go) => SceneManager.LoadScene("Shop");
        }

        Transform back = transform.Find("Top/Back");
        if (back != null)
        {
            UIEventListener.Get(back.gameObject).onClick += (go) => Application.Quit();
        }
    }

    void OnClickRank(GameObject go)
    {
        // 点击排行榜
    }
}
