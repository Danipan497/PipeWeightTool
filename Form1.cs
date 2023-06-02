using PipeWeightTool.PipesProperties;
using PipeWeightTool.DataSets;
using PipeWeightTool.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace PipeWeightTool
{
    public partial class Form1 : Form
    {
        double pi = Math.PI;
        public Form1()
        {
            InitializeComponent();
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

            pipeNominalDiameterTextBox.DataSource = pipesList;
            pipeNominalDiameterTextBox.DisplayMember = "pipename";
            pipeNominalDiameterTextBox.ValueMember = "nominaldiameter";

            var wallThicknessTableDataSet = DataSetsGenerator.WallThickness();
            DataNamesMapper<PipeSettings> mapperWallthickness = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> wallthicknessList = mapperWallthickness.Map(wallThicknessTableDataSet.Tables[0]).ToList();

            wallThicknessTextComboBox.DataSource = wallthicknessList;
            wallThicknessTextComboBox.DisplayMember = "wallthicknessname";
            wallThicknessTextComboBox.ValueMember = "wallthicknessvalue";

            var materialTableDataSet = DataSetsGenerator.Materials();
            DataNamesMapper<PipeSettings> mapperMaterial = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> materialsList = mapperMaterial.Map(materialTableDataSet.Tables[0]).ToList();

            materialComboBox.DataSource = materialsList;
            materialComboBox.DisplayMember = "materialname";
            materialComboBox.ValueMember = "densityvalue";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Important - that's how I get values from SelectedValue Combobox.
            //String s;
            //s = (comboBox1.SelectedValue).ToString();
            //double.TryParse(s, out double d);
            //double result = d * d;
            //label2.Text = result.ToString();

            double.TryParse(pipeNominalDiameterTextBox.SelectedValue.ToString(), out double nominalDiameterValue);
            double.TryParse(wallThicknessTextComboBox.SelectedValue.ToString(), out double wallThicknessValue);
            int.TryParse(materialComboBox.SelectedValue.ToString(), out int materialValue);
            double pipeLength = Convert.ToDouble(pipeLengthTextBox.Text);

            double pipeMassResult1 = Math.Pow((nominalDiameterValue / 1000) / 2, 2);
            double pipeMassResult2 = Math.Pow(((nominalDiameterValue / 1000) - 2 * (wallThicknessValue / 1000)) / 2, 2);

            double result = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength) * materialValue;
            label2.Text = result.ToString("N2");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
