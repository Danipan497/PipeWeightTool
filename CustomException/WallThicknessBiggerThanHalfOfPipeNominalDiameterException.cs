using System;

namespace PipeWeightTool.CustomException
{
    [Serializable]
    public class WallThicknessBiggerThanHalfOfPipeNominalDiameterException : Exception
    {
        public WallThicknessBiggerThanHalfOfPipeNominalDiameterException()
        {

        }
        public WallThicknessBiggerThanHalfOfPipeNominalDiameterException(string message) : base(message)
        {

        }
        public WallThicknessBiggerThanHalfOfPipeNominalDiameterException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
