using System.Windows.Controls;

namespace ProjectManager.Objects
{
    public class MyTreeViewItem : TreeViewItem
    {
        private int _headerIndex;
        private int _index;

        public int Index { get => _index; set => _index = value; }
        public int HeaderIndex { get => _headerIndex; set => _headerIndex = value; }

        public MyTreeViewItem() : base()
        {
        }
    }
}
