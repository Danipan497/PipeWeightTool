using PipeWeightTool.PipesProperties;
using PipeWeightTool.DataSets;
using PipeWeightTool.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PipeWeightTool.Calculations;

namespace PipeWeightTool
{
    public partial class Form1 : Form
    {
        private readonly IPipe pipe;
        public Form1(IPipe pipe)
        {
            InitializeComponent();
            this.pipe = pipe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            var pipesTableDataSet = DataSetsGenerator.Pipes();
            DataNamesMapper<PipeSettings> mapperPipes = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> pipesList = mapperPipes.Map(pipesTableDataSet.Tables[0]).ToList();

            pipeNominalDiameterComboBox.DataSource = pipesList;
            pipeNominalDiameterComboBox.DisplayMember = "pipename";
            pipeNominalDiameterComboBox.ValueMember = "nominaldiameter";

            var wallThicknessTableDataSet = DataSetsGenerator.WallThickness();
            DataNamesMapper<PipeSettings> mapperWallthickness = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> wallthicknessList = mapperWallthickness.Map(wallThicknessTableDataSet.Tables[0]).ToList();

            wallThicknessComboBox.DataSource = wallthicknessList;
            wallThicknessComboBox.DisplayMember = "wallthicknessname";
            wallThicknessComboBox.ValueMember = "wallthicknessvalue";

            var materialTableDataSet = DataSetsGenerator.Materials();
            DataNamesMapper<PipeSettings> mapperMaterial = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> materialsList = mapperMaterial.Map(materialTableDataSet.Tables[0]).ToList();

            materialComboBox.DataSource = materialsList;
            materialComboBox.DisplayMember = "materialname";
            materialComboBox.ValueMember = "densityvalue";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(pipeNominalDiameterTextBox.SelectedValue.ToString(), out double nominalDiameterValue);
            double.TryParse(wallThicknessTextComboBox.SelectedValue.ToString(), out double wallThicknessValue);
            int.TryParse(materialComboBox.SelectedValue.ToString(), out int materialValue);
            double.TryParse(pipeLengthTextBox.Text, out double pipeLength);

            string result = pipe.CalculatePipeWeight(nominalDiameterValue, wallThicknessValue, pipeLength, materialValue);
            pipeMassResultLabel.Text = result;
        }

        private void pipeLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
