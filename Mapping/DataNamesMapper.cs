﻿using PipeWeightTool.Attributes;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PipeWeightTool.Mapping
{
    public class DataNamesMapper<TEntity> where TEntity : class, new()
    {
        public TEntity Map(DataRow row)
        {
            TEntity entity = new TEntity();
            return Map(row, entity);
        }

        public TEntity Map(DataRow row, TEntity entity)
        {
            var columnNames = row.Table.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
            var properties = (typeof(TEntity)).GetProperties().Where(x => x.GetCustomAttributes(typeof(DataNamesAttribute), true).Any()).ToList();

            foreach ( var property in properties )
            {
                PropertyMapHelper.Map(typeof(TEntity), row, property, entity);
            }
            return entity;
        }

        public IEnumerable<TEntity> Map(DataTable table)
        {
            List<TEntity> entities = new List<TEntity>();
            var columnNames = table.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
            var properties = (typeof(TEntity)).GetProperties().Where(x => x.GetCustomAttributes(typeof(DataNamesAttribute), true).Any()).ToList();

            foreach (DataRow row in table.Rows) 
            {
                TEntity entity = new TEntity();
                foreach ( var property in properties )
                {
                    PropertyMapHelper.Map(typeof(TEntity), row, property, entity);
                }
                entities.Add(entity);
            }

            return entities;
        }
    }
}
