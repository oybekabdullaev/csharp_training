namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Vote { get; private set; }

        public void UpVote()
        {
            Vote += 1;
        }

        public void DownVote()
        {
            Vote -= 1;
        }
    }
}
