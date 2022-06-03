using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTreeView.Models
{
	// https://stackoverflow.com/questions/1912481/wpf-treeview-hierarchicaldatatemplate-binding-to-object-with-multiple-child-co

	public class Entry
	{
		public int Key { get; set; }
		public string Name { get; set; }
	}

	public class Group
	{
		public int Key { get; set; }
		public string Name { get; set; }

		public IList<Group> SubGroups { get; set; }
		public IList<Entry> Entries { get; set; }

		//public IEnumerable<object> Items
		//{
		//	get
		//	{
		//		foreach (var group in this.SubGroups)
		//			yield return group;
		//		foreach (var entry in this.Entries)
		//			yield return entry;
		//	}
		//}

		public IList<object> Items
		{
			get
			{
				IList<object> childNodes = new List<object>();
				foreach (var group in this.SubGroups)
					childNodes.Add(group);
				foreach (var entry in this.Entries)
					childNodes.Add(entry);

				return childNodes;
			}
		}
	}
}
