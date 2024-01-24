using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine;
using Engine.BaseAssets.Components;

namespace HoperfullyFinalTake.Content.Scripts
{
    public class TestComponent : BehaviourComponent
    {
        [SerializedField]
        private double Value = 5;
        public override void Start()
        {
            Logger.Log(LogType.Info, $"Start {Value}");
        }
        public override void Update()
        {
            
        }
    }
}
