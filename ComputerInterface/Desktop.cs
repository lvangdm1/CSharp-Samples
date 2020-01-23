using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInterface 
{
    class Desktop : Computer
    {
        private ISleep sleepController;
        public enum CaseType
        {
            Tower,
            MiniTower
        }
        public bool isSleeping
        {
            get
            {
                return sleepController.isSleeping;
            }
        }
        public CaseType caseType { get; private set; }

        // Overriding properties with base.name
        public override string name
        {
            get
            {
                return base.name + " " + caseType;
            }
        }
        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
            sleepController = new SleepController();
        }
        public void ToggleSleep()
        {
            if (!isOn)
            {
                return;
            }
            sleepController.ToggleSleep();
        }
        public override void TogglePower()
        {
            if(isSleeping)
            {
                return;
            }
            base.TogglePower();
        }
    }
}
