﻿using UnityEngine;
using System.Collections;
using MySpace;
//这是整个动作的鸡肋
//其他的动作都继承这个类
namespace ActionSpace
{

    public class SSAction : ScriptableObject
    {
        public bool enable = true;
        public bool destroy = false;

        public GameObject gameobject { get; set; }
        public Transform transform { get; set; }

        //interface 里面定义的接口
        public ISSActionCallback callback { get; set; }
        // Use this for initialization
        public virtual void Start()
        {
            throw new System.NotImplementedException();
        }

        // Update is called once per frame
        public virtual void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}