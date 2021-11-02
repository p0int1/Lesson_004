namespace Addition
{
    abstract class PartDoc
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
