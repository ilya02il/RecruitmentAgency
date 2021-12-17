using System;
using System.Collections.Generic;
using System.Linq;
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

				foreach (var property in record.GetType().GetProperties())
				{
					if (!properties.Any(p => p == property.Name))
						continue;

					var value = property.GetValue(record);

					values.Add(value);
				}

				dataGridView.Rows.Add(values.ToArray());
			}
		}

		public static DataGridViewRow GetSelectedRow(this DataGridView dataGridView)
		{
			if (dataGridView.SelectedCells.Count > 0)
				throw new Exception("You haven't selected any cells.");

			var selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;

			return dataGridView.Rows[selectedRowIndex];
		}
	}
}
