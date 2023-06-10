using System;
using System.Collections.Generic;

namespace Gardening
{
    public enum Color
    {
        Red,
        Blue,
        Yellow,
        Green,
        Pink,
        White,
        Black,
        Brown,
        Purple
    }

    public class PlantModel
    {
        private string plant;
        private Color color;
        private string type;
        private DateTime startBlossomPeriod;
        private DateTime endBlossomPeriod;
        private DateTime startPrunePeriods;
        private DateTime endPrunePeriods;

        public PlantModel(string plant, Color color, string type, DateTime startBlossomPeriod, DateTime endBlosomPeriod, DateTime startPrunePeriods, DateTime endPrunePeriods)
        {
            this.plant = plant;
            this.color = color;
            this.type = type;
            StartBlossomPeriod = startBlossomPeriod;
            EndBlosomPeriod = endBlosomPeriod;
            StartPrunePeriods = startPrunePeriods;
            EndPrunePeriods = endPrunePeriods;
        }

        public override string ToString()
        {
            return plant;
        }

        public string Plant
        {
            get { return plant; }
            set { plant = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public DateTime StartBlossomPeriod
        {
            get { return startBlossomPeriod; }
            set { startBlossomPeriod = value; }
        }

        public DateTime EndBlosomPeriod
        {
            get { return endBlossomPeriod; }
            set { endBlossomPeriod = value; }
        }

        public DateTime StartPrunePeriods
        {
            get { return startPrunePeriods; }
            set { startPrunePeriods = value; }
        }
        public DateTime EndPrunePeriods
        {
            get { return endPrunePeriods; }
            set { endPrunePeriods = value; }
        }
    }
}