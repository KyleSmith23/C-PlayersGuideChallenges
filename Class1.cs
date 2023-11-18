class Arrow
{
    public Arrow() { }
    public Arrow(string head, string tail, int length)
    {
        ArrowHead = head;
        ArrowTail = tail;
        ArrowLength = length;
    }

    public string ArrowHead { get; set;}
    public string ArrowTail { get; set;}
    public int ArrowLength { get; set; }
}