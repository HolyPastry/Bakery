using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Holypastry.Bakery 
{
    public interface IState
    {
        void Enter();
        void Update();
        void Exit();
        void FixedUpdate();
    }
}