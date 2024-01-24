using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LinearAlgebra;

using Engine;
using Engine.BaseAssets.Components;
using Editor;

namespace HoperfullyFinalTake.Content.Scripts
{
    public class MovingObject : BehaviourComponent
    {
        [SerializedField]
        private double Speed = 10;
        public override void Start()
        {


        }
        public override void Update()
        {
            GameObject.Transform.Position += new Vector3(-Time.DeltaTime * Speed, 0, 0);
            //GameObject.GetComponent<Rigidbody>()?.AddImpulse(new Vector3(-1, 0, 0) * Time.DeltaTime * Speed);
            if (GameObject.Transform.Position.x < -30)
            {
                GameObject.Destroy();
            }

        }
    }
}
