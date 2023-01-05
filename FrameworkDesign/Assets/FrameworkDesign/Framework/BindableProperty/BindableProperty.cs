using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace FrameworkDesign
{


    public class BindableProperty<T> where T : IEquatable<T>
    {
        private T mValue = default(T);
        public T Value
        {
            get => mValue;
            set
            {
                if (!value.Equals(mValue))
                {
                    mValue = value;
                    OnValueChanged?.Invoke(mValue);
                }
            }
        }
        public Action<T> OnValueChanged;

    }
}
