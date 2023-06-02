using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeWeightTool.Calculations
{
    public class Pipe : IPipe
    {
        readonly double pi = Math.PI;

        public string CalculatePipeWeight(double pipeNominalDiameter, double wallThickness, double pipeLength, int material)
        {
            double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);
            double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
            double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength) * material;

            return pipeMassResult.ToString("N2");
        }
    }
}
