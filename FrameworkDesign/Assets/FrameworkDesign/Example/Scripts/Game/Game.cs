using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            GameStartEvent.Register(OnGameStart);
            //GameModel.KillCount.OnValueChanged += OnEnemyKilled;
        }
        // private void OnEnemyKilled(int KillCount)
        // {
        //     if (KillCount == 10)
        //     {
        //         new PassGameCommand().Execute();
        //     }
        // }
        private void OnGameStart()
        {
            transform.Find("Enemies").gameObject.SetActive(true);
        }
        private void OnDestroy()
        {
            GameStartEvent.UnRegister(OnGameStart);
            //GameModel.KillCount.OnValueChanged -= OnEnemyKilled;
        }
    }

}