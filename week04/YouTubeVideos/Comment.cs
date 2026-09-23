public class Comment
{
    private string _commentName;
    private string _text;

    public Comment(string commentName, string text)
    {
        _commentName = commentName;
        _text = text;
    }

    public string GetCommentName()
    {
        return _commentName;
    }

    public string GetText()
    {
        return _text;
    }
}