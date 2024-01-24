using Engine.BaseAssets.Components;
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
    public class Spawner : BehaviourComponent
    {
        [SerializedField]
        private Model model;
        private double time = 0;
        [SerializedField]
        private double spawnTime = 3;
        public override void Start()
        {


        }
        public override void Update()
        {
            GameObject Obstacle = GameObject.Instantiate("Obstacle");
            Obstacle.Transform.Position = GameObject.Transform.Position;
            Obstacle.Transform.LocalScale = new LinearAlgebra.Vector3(1, 1, 1);
            Obstacle.AddComponent<MovingObject>();
            Obstacle.AddComponent<MeshComponent>();
            Obstacle.GetComponent<MeshComponent>().Model = model;
            Obstacle.AddComponent<Rigidbody>();
            

           
        }
    }
}
