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
using Engine.BaseAssets.Components.Colliders;

namespace HoperfullyFinalTake.Content.Scripts
{
    public class Spawner : BehaviourComponent
    {
        [SerializedField]
        private Model model;
        private double time = 0;
        [SerializedField]
        private double spawnTime = 3;
        private int PrefabIndex = 0;
        public override void Start()
        {


        }
        public override void Update() {
            time += Time.DeltaTime;
            if (time > spawnTime)
            {
                Random rnd = new Random();
                int PrefabIndex = rnd.Next(1, 3);
                double PrefabPositionZ = rnd.NextDouble() * 12 - 3;
           
                GameObject Obstacle = GameObject.Instantiate("Obstacle");
                Obstacle.Transform.Position = GameObject.Transform.Position;
                Obstacle.Transform.Position += new Vector3(0,0,PrefabPositionZ);
                Obstacle.AddComponent<CubeCollider>();
                Obstacle.GetComponent<CubeCollider>().Size = new Vector3(2, 2, 2);
                switch (PrefabIndex)
                {
                    case 1:
                        Obstacle.Transform.LocalScale = new LinearAlgebra.Vector3(1, 1, 1.6);
                        break;
                    case 2:
                        Obstacle.Transform.LocalScale = new LinearAlgebra.Vector3(1.5, 1, 2);
                        break;
                    case 3:
                        Obstacle.Transform.LocalScale = new LinearAlgebra.Vector3(1.15, 1.5, 1.5);
                        break;
                    default:
                        break;

                }

                Obstacle.AddComponent<MovingObject>();
                Obstacle.AddComponent<MeshComponent>();
                Obstacle.GetComponent<MeshComponent>().Model = model;
                Obstacle.AddComponent<Rigidbody>();
                //Obstacle.GetComponent<Rigidbody>().ignoreGravity = true;
          
                time = 0;
            }


        }
    }
}
