namespace Task3
{
    internal class Post
    {
        private string _position;
        private string _surname;

        public Post(string surname, string poistion)
        {
            _surname = surname;
            _position = poistion;
        }

        public string Position => _position;
        public string Surname => _surname;
    }
}
