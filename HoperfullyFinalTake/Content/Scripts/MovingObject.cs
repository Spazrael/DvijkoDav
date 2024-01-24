using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LinearAlgebra;

using Engine;
using Engine.BaseAssets.Components;

namespace HoperfullyFinalTake.Content.Scripts
{
    public class MovingObject : BehaviourComponent
    {
        [SerializedField]
        private double Speed = 5;
        private double time = 0;
        public override void Start()
        {


        }
        public override void Update()
        {
            GameObject.Transform.Position = new Vector3(GameObject.Transform.Position.x - Time.DeltaTime * Speed, GameObject.Transform.Position.y, GameObject.Transform.Position.z);
            
        }
    }
}
