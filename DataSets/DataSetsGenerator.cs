using System.Data;


namespace PipeWeightTool.DataSets
{
    public static class DataSetsGenerator
    {
        public static DataSet Pipes()
        {
            DataTable pipesTable = new DataTable();

            pipesTable.Columns.Add(new DataColumn()
            {
                ColumnName = "id",
                DataType = typeof(int)
            });
            pipesTable.Columns.Add(new DataColumn()
            {
                ColumnName = "pipename",
                DataType = typeof(string)
            });
            pipesTable.Columns.Add(new DataColumn()
            {
                ColumnName = "nominaldiameter",
                DataType = typeof(double)
            });

            pipesTable.Rows.Add(new object[] { 1, "DN6", 10.2 });
            pipesTable.Rows.Add(new object[] { 2, "DN8", 13.5 });
            pipesTable.Rows.Add(new object[] { 3, "DN10", 17.2 });
            pipesTable.Rows.Add(new object[] { 4, "DN15", 21.3 });
            pipesTable.Rows.Add(new object[] { 5, "DN20", 26.9 });
            pipesTable.Rows.Add(new object[] { 6, "DN25", 33.7 });
            pipesTable.Rows.Add(new object[] { 7, "DN32", 42.4 });
            pipesTable.Rows.Add(new object[] { 8, "DN40", 48.3 });
            pipesTable.Rows.Add(new object[] { 9, "DN50", 60.3 });
            pipesTable.Rows.Add(new object[] { 10, "DN65", 76.1});
            pipesTable.Rows.Add(new object[] { 11, "DN80", 88.9 });
            pipesTable.Rows.Add(new object[] { 12, "DN100", 114.3 });
            pipesTable.Rows.Add(new object[] { 13, "DN125", 139.7 });
            pipesTable.Rows.Add(new object[] { 14, "DN150", 168.3 });
            pipesTable.Rows.Add(new object[] { 15, "DN200", 219.1 });
            pipesTable.Rows.Add(new object[] { 16, "DN250", 273.0 });
            pipesTable.Rows.Add(new object[] { 17, "DN300", 323.9 });
            pipesTable.Rows.Add(new object[] { 18, "DN350", 355.6 });
            pipesTable.Rows.Add(new object[] { 19, "DN400", 406.4 });
            pipesTable.Rows.Add(new object[] { 20, "DN450", 457.2 });
            pipesTable.Rows.Add(new object[] { 21, "DN500", 508.0 });
            pipesTable.Rows.Add(new object[] { 22, "DN600", 609.6 });
            pipesTable.Rows.Add(new object[] { 23, "DN700", 711.2 });
            pipesTable.Rows.Add(new object[] { 24, "DN800", 812.8 });
            pipesTable.Rows.Add(new object[] { 25, "DN900", 914.4 });
            pipesTable.Rows.Add(new object[] { 26, "DN1000", 1016.0 });
            pipesTable.Rows.Add(new object[] { 27, "DN1200", 1220.0 });
            pipesTable.Rows.Add(new object[] { 28, "DN1400", 1420.0 });
            pipesTable.Rows.Add(new object[] { 29, "DN1600", 1620.0 });
            pipesTable.Rows.Add(new object[] { 30, "DN1800", 1820.0 });
            pipesTable.Rows.Add(new object[] { 31, "DN2000", 2020.0 });

            DataSet pipesTableDataSet = new DataSet();
            pipesTableDataSet.Tables.Add(pipesTable);

            return pipesTableDataSet;
        }

        public static DataSet WallThickness()
        {
            DataTable wallThicknessTable = new DataTable();

            wallThicknessTable.Columns.Add(new DataColumn()
            {
                ColumnName = "idwallthickness",
                DataType = typeof(int)
            });
            
            wallThicknessTable.Columns.Add(new DataColumn()
            {
                ColumnName = "wallthicknessname",
                DataType = typeof(string)
            });

            wallThicknessTable.Columns.Add(new DataColumn()
            {
                ColumnName = "wallthicknessvalue",
                DataType = typeof(double)
            });

            wallThicknessTable.Rows.Add(new object[] {1, "1,6", 1.6 });
            wallThicknessTable.Rows.Add(new object[] {2, "1,8", 1.8 });
            wallThicknessTable.Rows.Add(new object[] {3, "2,0", 2.0 });
            wallThicknessTable.Rows.Add(new object[] {4, "2,3", 2.3 });
            wallThicknessTable.Rows.Add(new object[] {5, "2,6", 2.6 });
            wallThicknessTable.Rows.Add(new object[] {6, "2,9", 2.9 });
            wallThicknessTable.Rows.Add(new object[] {7, "3,2", 3.2 });
            wallThicknessTable.Rows.Add(new object[] {8, "3,6", 3.6 });
            wallThicknessTable.Rows.Add(new object[] {9, "4,0", 4.0 });
            wallThicknessTable.Rows.Add(new object[] {10, "4,5", 4.5 });
            wallThicknessTable.Rows.Add(new object[] {11, "5,0", 5.0 });
            wallThicknessTable.Rows.Add(new object[] {12, "5,6", 5.6 });
            wallThicknessTable.Rows.Add(new object[] {13, "6,3", 6.3 });
            wallThicknessTable.Rows.Add(new object[] {14, "7,1", 7.1 });
            wallThicknessTable.Rows.Add(new object[] {15, "8,0", 8.0 });
            wallThicknessTable.Rows.Add(new object[] {16, "8,8", 8.8 });
            wallThicknessTable.Rows.Add(new object[] {17, "10,0", 10.0 });
            wallThicknessTable.Rows.Add(new object[] {18, "11,0", 11.0 });
            wallThicknessTable.Rows.Add(new object[] {19, "12,5", 12.5 });
            wallThicknessTable.Rows.Add(new object[] {20, "14,2", 14.2 });

            DataSet wallThicknessTableDataSet = new DataSet();
            wallThicknessTableDataSet.Tables.Add(wallThicknessTable);

            return wallThicknessTableDataSet;
        }

        public static DataSet Materials()
        {
            DataTable materialsTable = new DataTable();

            materialsTable.Columns.Add(new DataColumn()
            {
                ColumnName = "idmaterials",
                DataType = typeof(int)
            });

            materialsTable.Columns.Add(new DataColumn()
            {
                ColumnName = "materialname",
                DataType = typeof(string)
            });

            materialsTable.Columns.Add(new DataColumn()
            {
                ColumnName = "densityvalue",
                DataType = typeof(int)
            });

            materialsTable.Rows.Add(new object[] {1, "Carbon steel", 7840 });
            materialsTable.Rows.Add(new object[] {2, "PVC", 1450 });
            materialsTable.Rows.Add(new object[] {3, "Pure iron", 7860 });
            materialsTable.Rows.Add(new object[] {4, "Wrought iron", 7750 });
            materialsTable.Rows.Add(new object[] {5, "Mild steel", 7880 });
            materialsTable.Rows.Add(new object[] {6, "Stainless steel", 8030 });
            materialsTable.Rows.Add(new object[] {7, "Aluminum", 2700 });
            materialsTable.Rows.Add(new object[] {8, "Brass", 8500 });
            materialsTable.Rows.Add(new object[] {9, "Copper", 8960 });

            DataSet materialTableDataSet = new DataSet();
            materialTableDataSet.Tables.Add(materialsTable);

            return materialTableDataSet;
        }
    }
}
