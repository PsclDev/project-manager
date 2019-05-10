namespace ProjectManager
{
    public class Property
    {
        private int _id;
        private string _title;
        private string _body;

        public int ID { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Body { get => _body; set => _body = value; }

        public Property(int id, string title, string body)
        {
            ID = id;
            Title = title;
            Body = body;
        }
    }
}
