using Engine;
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
    public class BackgroundMovingObject : BehaviourComponent
    {
        [SerializedField]
        private double Speed = 10;
        [SerializedField]
        private double respawnPositionX = -40;
        private Random random = new Random();
        private Vector3 startPosition;
        private double startSpeed;

        public override void Start()
        {
            startPosition = new Vector3(GameObject.Transform.Position.x, GameObject.Transform.Position.y, GameObject.Transform.Position.z);
            startSpeed = Speed;
        }
        public override void Update()
        {   
            
            GameObject.Transform.Position += new Vector3(-Time.DeltaTime * Speed, 0, 0);
            //GameObject.GetComponent<Rigidbody>()?.AddImpulse(new Vector3(-1, 0, 0) * Time.DeltaTime * Speed);
            if (GameObject.Transform.Position.x < respawnPositionX)
            {
                GameObject.Transform.Position = startPosition;
                Speed = (random.NextDouble() + 1)  * startSpeed;
            }

        }
    }
    
}
