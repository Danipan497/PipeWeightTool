using PipeWeightTool.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeWeightTool.PipesProperties
{
    public class PipeSettings
    {
        [DataNames("id")]
        public string Id { get; set; }

        [DataNames("pipename")]
        public string PipeName { get; set; }

        [DataNames("nominaldiameter")]
        public string NominalDiameter { get; set; }

        [DataNames("idwallthickness")]
        public string IdWallthickness { get; set; }

        [DataNames("wallthicknessname")]
        public string WallThicknessName { get; set; }

        [DataNames("wallthicknessvalue")]
        public string WallThicknessValue { get; set; }

        [DataNames("idmaterials")]
        public string IdMaterial { get; set; }

        [DataNames("materialname")]
        public string MaterialName { get; set; }

        [DataNames("densityvalue")]
        public string DensityValue { get; set; }

    }
}
