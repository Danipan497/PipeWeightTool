using System;

namespace PipeWeightTool.CustomException
{
    [Serializable]
    public class WallThicknessBiggerThanPipeNominalDiameterException : Exception
    {
        public WallThicknessBiggerThanPipeNominalDiameterException()
        {

        }
        public WallThicknessBiggerThanPipeNominalDiameterException(string message) : base(message)
        {

        }
        public WallThicknessBiggerThanPipeNominalDiameterException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
