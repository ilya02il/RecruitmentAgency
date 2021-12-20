using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Helpers
{
    public static class DataGridViewExtension
	{
		public static void LoadData<TRecord>(this DataGridView dataGridView, IEnumerable<TRecord> records, params string[] properties)
			where TRecord : class
		{
			dataGridView.Rows.Clear();

			foreach (var record in records)
			{
				List<object> values = new();

				for (int i = 0; i < properties.Length; i++)
				{ 
					foreach (var property in record.GetType().GetProperties())
					{
						if (properties[i] == property.Name)
							values.Add(property.GetValue(record));

						continue;
					}
				}

				dataGridView.Rows.Add(values.ToArray());
			}
		}

		public static DataGridViewRow GetSelectedRow(this DataGridView dataGridView)
		{
			if (dataGridView.SelectedCells.Count == 0)
				throw new Exception("You haven't selected any cells.");

			var selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;

			return dataGridView.Rows[selectedRowIndex];
		}
	}
}
