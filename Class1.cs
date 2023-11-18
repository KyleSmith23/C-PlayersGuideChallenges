class Arrow
{
    private string arrowHead;
    private string arrowTail;
    private int arrowLength;

    public Arrow() { }
    public Arrow (string head,  string tail, int length)
    {
        arrowHead = head;
        arrowTail = tail;
        arrowLength = length;
    }

    public string GetArrowHead() => arrowHead;
    public string GetArrowTail() => arrowTail; 
    public int GetArrowLength() => arrowLength;

    public string SetArrowHead(string input) => arrowHead = input;
    public string SetArrowTail(string input) => arrowTail = input;

    public int SetArrowLength(int value) => arrowLength = value;
}