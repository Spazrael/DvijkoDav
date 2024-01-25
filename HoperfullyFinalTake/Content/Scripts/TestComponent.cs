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
    public class TestComponent : BehaviourComponent
    {
        [SerializedField]
        private Sound sound = null;
        [SerializedField]
        private double Impulse = 5;
        private Random random = new Random();
        public override void Start()
        {
            
            
        }
        public override void Update()
        {
            
            if (Input.IsKeyPressed(System.Windows.Input.Key.E)) 
            {
                GameObject.GetComponent<Rigidbody>()?.AddImpulse(new Vector3(0, 0, 1) * Impulse);
                GameObject.GetComponent<SoundSource>()?.play(sound);
            }
        }
    }
}
