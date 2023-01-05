using System;
using System.Collections;
using System.Collections.Generic;
using FrameworkDesign;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp
{


    public class CounterViewController : MonoBehaviour
    {
        private CounterModel mCounterModel;
        private void Start()
        {
            mCounterModel = CounterApp.Get<CounterModel>();

            mCounterModel.Count.OnValueChanged += OnCountChanged;

            OnCountChanged(mCounterModel.Count.Value);

            transform.Find("BtnAdd").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                new AddCountCommand().Execute();

            });
            transform.Find("BtnSub").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑 : 自动触发表现逻辑
                new SubCountCommand().Execute();

            });
        }

        private void OnCountChanged(int newCount)
        {
            transform.Find("CountText").GetComponent<Text>().text = newCount.ToString();
        }
        private void OnDestroy()
        {
            mCounterModel.Count.OnValueChanged -= OnCountChanged;
            mCounterModel = null;
        }



    }
    public class CounterModel
    {


        public BindableProperty<int> Count = new BindableProperty<int>()
        {
            Value = 0
        };

    }

}
