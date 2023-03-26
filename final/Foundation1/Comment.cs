public class Comment
{
    private string _name;
    private string _content;

    public void SetComment(string name, string commentContent)
    {
        this._name = name;
        this._content = commentContent;
    }

    public string GetComment()
    {
        string comment = _name + ": " + _content;
        return comment;
    }
}