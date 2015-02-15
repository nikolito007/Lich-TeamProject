using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LichtOut
{
    class LightTile : Button
    {
        //TODO: make a button
        //list of neightbours
        //onclick event
        private List<LightTile> neighbours;
        private bool on;
        private Color onColor;
        private Color offColor;

        public LightTile(Color onColor, Color offColor, bool on = false)
        {
            this.On = on;
            this.neighbours = new List<LightTile>();
            this.onColor = onColor;
            this.offColor = offColor;
        }

        public bool On
        {
            get
            {
                return this.on;
            }
            set
            {
                this.on = value;
            }
        }

        public void AddNeigbour(LightTile neighbour)
        {
            this.neighbours.Add(neighbour);
        }

        
    }
}
