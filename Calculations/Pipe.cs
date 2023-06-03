﻿using System;
using PipeWeightTool.CustomException;

namespace PipeWeightTool.Calculations
{
    public class Pipe : IPipe
    {
        readonly double pi = Math.PI;

        public string CalculatePipeWeight(double pipeNominalDiameter, double wallThickness, double pipeLength, int material)
        {
            try
            {
                if (wallThickness > pipeNominalDiameter)
                {
                    throw new WallThicknessBiggerThanPipeNominalDiameterException();

                }
                else if (wallThickness > pipeNominalDiameter / 2)
                {
                    throw new WallThicknessBiggerThanHalfOfPipeNominalDiameterException();
                }
                else
                {
                    double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);
                    double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
                    double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength) * material;

                    return pipeMassResult.ToString("N3");
                }
            }
            catch (WallThicknessBiggerThanPipeNominalDiameterException)
            {
                return string.Empty;
                throw new WallThicknessBiggerThanPipeNominalDiameterException("Pipe wall thickness cannot be larger than outside diameter! Incorrect action!");
            }
            catch (WallThicknessBiggerThanHalfOfPipeNominalDiameterException)
            {
                return string.Empty;
                throw new WallThicknessBiggerThanHalfOfPipeNominalDiameterException("Pipe wall thickness cannot be larger than half of outside diameter! Incorrect action!");
            }
        }
    }
}
